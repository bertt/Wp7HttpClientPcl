using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wp7HttpClientPcl.Core;

namespace Wp7HttpClientPcl.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var s = await DataGetter.GetSomeEarthquakeData();
            MessageBox.Show("Data: " + s);
        }
    }
}
