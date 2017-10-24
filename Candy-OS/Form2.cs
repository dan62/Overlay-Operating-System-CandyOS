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
    public partial class Form2 : Form
    {
        int start_hit;
        public static int keepTrack = 0;

        public Form2()
        {
            InitializeComponent();
            
        }

 

        private void Form2_Load(object sender, EventArgs e)
        {

           

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            start_overlay.Hide();
            bar.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            opened1.Hide();

            time.Text = DateTime.Now.ToShortTimeString().ToString();

          

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (start_hit == 0)
            {
                bar.Show();
                start_overlay.Show();
                startbutton_label1.Show();
                startbutton_label2.Show();
                mozila_start_menu.Show();
                settings_start_menu.Show();
                music_start_menu.Show();

                start_hit = 1;
            }else
            {
                bar.Hide();
                start_overlay.Hide();
                startbutton_label1.Hide();
                startbutton_label2.Hide();
                mozila_start_menu.Hide();
                settings_start_menu.Hide();
                music_start_menu.Hide();
                start_hit = 0;
                opened1.Hide();
            }
        }

        private void start_overlay_Click(object sender, EventArgs e)
        {

        }

        private void web_browser1_Click(object sender, EventArgs e)
        {
            bar.Hide();
            start_overlay.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            start_hit = 0;

            firefox frm = new firefox();
            frm.Show();

            opened1.BackgroundImage= Properties.Resources.firefox;
            opened1.Show();
        }

        private void microsoft_excel_Click(object sender, EventArgs e)
        {

        }

        private void mozila_start_menu_Click(object sender, EventArgs e)
        {
            bar.Hide();
            start_overlay.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            start_hit = 0;

            firefox frm = new firefox();
            frm.Show();

            opened1.BackgroundImage = Properties.Resources.firefox;
            opened1.Show();
        }

        private void settings_icon_Click(object sender, EventArgs e)
        {
            bar.Hide();
            start_overlay.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            start_hit = 0;

            settings frm = new settings();
            frm.Show();

            opened1.BackgroundImage = Properties.Resources.Settings_Logo;
            opened1.Show();
        }

        private void settings_start_menu_Click(object sender, EventArgs e)
        {
            bar.Hide();
            start_overlay.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            start_hit = 0;

            settings frm = new settings();
            frm.Show();

            opened1.BackgroundImage = Properties.Resources.Settings_Logo;
            opened1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result1 =MessageBox.Show("Do you want to shutdown?", "Shutdown", MessageBoxButtons.YesNo,  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result1==DialogResult.Yes)
            {
                //the code to shutdown computer will go here
                this.Close();
            }
        }

        private void web_browser2_Click(object sender, EventArgs e)
        {
            bar.Hide();
            start_overlay.Hide();
            startbutton_label1.Hide();
            startbutton_label2.Hide();
            mozila_start_menu.Hide();
            settings_start_menu.Hide();
            music_start_menu.Hide();
            start_hit = 0;

            Google_Chrome frm = new Google_Chrome();
            frm.Show();

            opened1.BackgroundImage = Properties.Resources.chrome;
            opened1.Show();
        }

        private void blackboard_logo_Click(object sender, EventArgs e)
        {
            Blackboard frm = new Blackboard();
            frm.Show();
            opened1.BackgroundImage = Properties.Resources.Blackboard_Inc__logo;
            opened1.Show();
        }

        private void microsoft_word_Click(object sender, EventArgs e)
        {
            Microsoft_Word frm = new Microsoft_Word();
            frm.Show();
            opened1.BackgroundImage = Properties.Resources.Microsoft_Word_2013_logo_svg;
            opened1.Show();
        }
    }
}
