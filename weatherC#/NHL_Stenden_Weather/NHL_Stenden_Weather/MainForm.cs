using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;

namespace NHL_Stenden_Weather
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Thread for splash-screen
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);

            InitializeComponent();
            refreshApi();
            StartTime(60000);

            //Makes application non resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Closing form event
            this.FormClosing += this.Form1_FormClosing;

            t.Abort();
        }

        //Function for running the splash-screen
        public void StartForm()
        {
            Application.Run(new splashScreen());
        }


        //Closing the form event handler
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "WeatherStation was minimized to tray.";
                notifyIcon1.ShowBalloonTip(1000);
                this.Hide();
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Below are the events associated with the context menu
        /// </summary>
        /// 

        //Open about
        private void aboutToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.Show();
        }

        //Refresh application
        private void refreshToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            //refreshApi();
        }

        //Open options
        private void optionsToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Show();
        }

        //Open application
        private void openToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            Show();
        }

        //Close application
        private void closeToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = "WeatherStation was closed.";
            notifyIcon1.ShowBalloonTip(1000);
            Application.Exit();
        }


        //Method for the API
        private void refreshApi()
        {
            //Variables used
            string city;

            string weatherDesc;
            string location;
            double temperature;
            string temperatureString;
            double wind;
            string windString;
            string humidity;
            string units;
            string iconCode;
            char unit;

            city = inputCity.Text;

            if (String.IsNullOrEmpty(inputCity.Text))
            {
                city = "Emmen";
            }

            if (radioButton1.Checked)
            {
                units = "imperial";
                unit = 'F';
            }
            else
            {
                units = "metric";
                unit = 'C';
            }

            string url = "http://api.openweathermap.org/data/2.5/weather?mode=xml&appid=ead3a55304596268baa5c68bb1afdfc6&q=" + city + "&units=" + units;

            //Loading information from the API
            XDocument doc = XDocument.Load(url);
            weatherDesc = doc.Root.Element("weather").Attribute("value").Value;
            location = doc.Root.Element("city").Attribute("name").Value + ", " +(string)doc.Descendants("country").FirstOrDefault();
            double.TryParse(doc.Root.Element("temperature").Attribute("value").Value, out temperature);
            iconCode = doc.Root.Element("weather").Attribute("icon").Value;
            double.TryParse(doc.Root.Element("wind").Element("speed").Attribute("value").Value, out wind);
            humidity = doc.Root.Element("humidity").Attribute("value").Value + "%";
            

            if (unit == 'F')
            {
                temperatureString = temperature + " F";
                windString = wind + " MPH";
            }
            else
            {
                wind = wind * 3.6;
                temperatureString = temperature + " °C";
                windString = wind + " Km/h";
            }

            //Loading the icon
            string iconUrl = "http://openweathermap.org/img/wn/" + iconCode + ".png";
            WebClient client = new WebClient();
            byte[] image = client.DownloadData(iconUrl);
            MemoryStream stream = new MemoryStream(image);
            Bitmap newBitMap = new Bitmap(stream);
            Bitmap icon = newBitMap;

            txtCond.Text = weatherDesc;
            txtLocation.Text = location;
            txtTemp.Text = temperatureString;
            txtHumid.Text = humidity;
            txtWind.Text = windString;
            picWeather.Image = icon;

            updateDatabase(temperature, location, unit);
            txtUpdate.Text = "Last updated:" + DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Starts timer and raises an event
        /// </summary>
        /// <param name="seconds">Chosen interval entered by user</param>
        private void StartTime(int seconds)
        {

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Tick += new EventHandler(timer_Tick);

            timer.Enabled = true;

            try
            {
                timer.Interval = seconds;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                timer.Interval = 60000;
            }

        }

        //Handles the event
        void timer_Tick(object sender, EventArgs e)
        {
            refreshApi();
        }

        //Options button
        private void button1_Click(object sender, EventArgs e)
        {
            int seconds;

            if (!int.TryParse(txtInterval.Text, out seconds))
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Invalid number.";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            {
                seconds = seconds * 1000;
            }

            StartTime(seconds);

            refreshApi();
            tabControl1.SelectedTab = tabPage1;
        }
        /// <summary>
        /// Inserting data into the database
        /// </summary>
        /// <param name="temp">The temperature to be saved</param>
        /// <param name="city">The city where the data was measured</param>
        /// <param name="unit">Farenheit (F) or degree celsius (C)</param>
        private void updateDatabase(double temp, string city, char unit)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\takac\OneDrive\Documents\GitHub\myWork\weatherC#\NHL_Stenden_Weather\NHL_Stenden_Weather\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insert into weather(day, temperature, city, unitOfMeasure) values('" + DateTime.Now + "', '" + temp + "', '" + city + "', '" + unit + "')", con);

            com.ExecuteNonQuery();

            con.Close();
        }
    }
}
