using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHL_Stenden_Weather
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();

            //Makes application non resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
