using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KairosChallenge
{
    public partial class frmUrlLink : Form
    {
        DecodeURL BuildUrl = new DecodeURL();
        public frmUrlLink()
        {
            InitializeComponent();

            infoTxt.Text = "Si pulsas el botón te llevara a la URL: " + BuildUrl.URL;
        }

        private void urlBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(BuildUrl.URL);
        }
    }
}
