using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candy_OS
{
    public partial class firefox : Form
    {
        
        public firefox()
        {
            InitializeComponent();
    }

        private void firefox_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.google.com");

            if (this.Visible)
            {
                Form2.keepTrack = 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://"+address.Text));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.google.com");
        }
    }
}
