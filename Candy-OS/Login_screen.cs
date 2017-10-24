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
    public partial class Login_screen : Form
    {
        public Login_screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            incorrect.Hide();
        }

        private void password_TextChanged(object sender, System.EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.blurred1;
            
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (password.Text == "ilovestamforduniversity")
            {
                incorrect.Hide();
                password.ForeColor = Color.Black;
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else {

                incorrect.Show();
                password.ForeColor = Color.Red;

            };
        }
    }
}
