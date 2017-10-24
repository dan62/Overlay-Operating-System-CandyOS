using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Candy_OS
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void change_name_button_Click(object sender, EventArgs e)
        {
            input_new_name.Show();
            pc_name.Text = input_new_name.Text;
            if (pc_name.Text != "enter new name here")
            {
                DialogResult result1 = MessageBox.Show("Your PC name has been changed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                input_new_name.Hide();
            }
            

        }

        private void selected2_Click(object sender, EventArgs e)
        {
            selected1.Hide();
            system_summary.BackColor=Color.SlateBlue;

            selected2.Show();
            system_users_button.BackColor=Color.MediumSlateBlue;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            input_new_name.Hide();
            current_user_pp.Hide();
            current_user_name.Hide();
            current_user_role.Hide();
            change_pp.Hide();
            selected2.Hide();
            selected3.Hide();
            seperation.Hide();
            add_user_instruction.Hide();
            system_users_button.BackColor = Color.SlateBlue;
            apperance_label.BackColor = Color.SlateBlue;

            user_fname_textbox.Hide();
            username_lname.Hide();
            student_id.Hide();
            user_privalage_level.Hide();
            faculty.Hide();
            advisor.Hide();
            terms.Hide();
            Add_user.Hide();
            password1.Hide();
            password2.Hide();

            wallpaper.Hide();
            wallpaper_label.Hide();
            change_wallpaper.Hide();
            screensaver.Hide();
            screen_saver_label.Hide();
            change_screen_saver.Hide();
            theme.Hide();
            theme_label.Hide();
            change_theme.Hide();
            save_apply.Hide();
            


             if(pc_name.Text == "name") { 
            pc_name.Text = System.Environment.MachineName;
        }
        }

        private void system_users_button_Click(object sender, EventArgs e)
        {
            selected1.Hide();
            system_summary.BackColor = Color.SlateBlue;

            selected2.Show();
            seperation.Show();
            add_user_instruction.Show();
            system_users_button.BackColor = Color.MediumSlateBlue;
            apperance_label.BackColor = Color.SlateBlue;

            pc_name_label.Hide();
            pc_name.Hide();
            change_name_button.Hide();
            organization_label.Hide();
            organization.Hide();
            version_label.Hide();
            version.Hide();
            organization_label.Hide();
            organization.Hide();
            processor_label.Hide();
            processor.Hide();
            ram_label.Hide();
            ram.Hide();
            rom_label.Hide();
            rom.Hide();
            system_type_label.Hide();
            system_type.Hide();

            wallpaper.Hide();
            wallpaper_label.Hide();
            change_wallpaper.Hide();
            screensaver.Hide();
            screen_saver_label.Hide();
            change_screen_saver.Hide();
            theme.Hide();
            theme_label.Hide();
            change_theme.Hide();
            save_apply.Hide();

            selected3.Hide();

            user_fname_textbox.Show();
            username_lname.Show();
            student_id.Show();
            user_privalage_level.Show();
            faculty.Show();
            advisor.Show();
            terms.Show();
            Add_user.Show();
            password1.Show();
            password2.Show();

            current_user_pp.Show();
            current_user_name.Show();
            current_user_role.Show();
            change_pp.Show();

        }

        private void system_summary_Click(object sender, EventArgs e)
        {
            current_user_pp.Hide();
            current_user_name.Hide();
            current_user_role.Hide();
            change_pp.Hide();
            selected2.Hide();
            seperation.Hide();
            add_user_instruction.Hide();

            user_fname_textbox.Hide();
            username_lname.Hide();
            student_id.Hide();
            user_privalage_level.Hide();
            faculty.Hide();
            advisor.Hide();
            terms.Hide();
            Add_user.Hide();
            password1.Hide();
            password2.Hide();

            wallpaper.Hide();
            wallpaper_label.Hide();
            change_wallpaper.Hide();
            screensaver.Hide();
            screen_saver_label.Hide();
            change_screen_saver.Hide();
            theme.Hide();
            theme_label.Hide();
            change_theme.Hide();
            save_apply.Hide();


            selected3.Hide();

            system_users_button.BackColor = Color.SlateBlue;
            apperance_label.BackColor = Color.SlateBlue;

            selected1.Show();
            system_summary.BackColor = Color.MediumSlateBlue;

            pc_name_label.Show();
            pc_name.Show();
            change_name_button.Show();
            organization_label.Show();
            organization.Show();
            version_label.Show();
            version.Show();
            organization_label.Show();
            organization.Show();
            processor_label.Show();
            processor.Show();
            ram_label.Show();
            ram.Show();
            rom_label.Show();
            rom.Show();
            system_type_label.Show();
            system_type.Show();
        }

        private void sidebar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.keepTrack = 0;
        }

        private void change_pp_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                current_user_pp.BackgroundImage = new Bitmap(open.FileName);
                
            }
        }

        private void Add_user_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=http://www.pangai-search.com;port=3307;username=zredkshd_candyOS; password =password1234$";

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into zredkshd_CandyOS.users(student_id,first_name,last_name,role,faculty_major,Advisor,terms_conditions,online_status,password) values('" + this.student_id.Text + "','" + this.user_fname_textbox.Text + "','" + this.username_lname.Text + "','" + this.user_privalage_level.Text + "','" + this.faculty.Text + "','"+ this.advisor.Text + "','"+ this.terms.Text+"','"+"false"+ this.password1.Text + "');";



                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            current_user_pp.Hide();
            current_user_name.Hide();
            current_user_role.Hide();
            change_pp.Hide();
            selected2.Hide();
            seperation.Hide();
            add_user_instruction.Hide();

            user_fname_textbox.Hide();
            username_lname.Hide();
            student_id.Hide();
            user_privalage_level.Hide();
            faculty.Hide();
            advisor.Hide();
            terms.Hide();
            Add_user.Hide();

            pc_name_label.Hide();
            pc_name.Hide();
            change_name_button.Hide();
            organization_label.Hide();
            organization.Hide();
            version_label.Hide();
            version.Hide();
            organization_label.Hide();
            organization.Hide();
            processor_label.Hide();
            processor.Hide();
            ram_label.Hide();
            ram.Hide();
            rom_label.Hide();
            rom.Hide();
            system_type_label.Hide();
            system_type.Hide();
            password1.Hide();
            password2.Hide();

            selected3.Show();
            apperance_label.BackColor = Color.MediumSlateBlue;
            system_summary.BackColor = Color.SlateBlue;
            system_users_button.BackColor = Color.SlateBlue;
            selected1.Hide();
            selected2.Hide();

            wallpaper.Show();
            wallpaper_label.Show();
            change_wallpaper.Show();
            screensaver.Show();
            screen_saver_label.Show();
            change_screen_saver.Show();
            theme.Show();
            theme_label.Show();
            change_theme.Show();
            save_apply.Show();
        }

        private void change_wallpaper_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                wallpaper.BackgroundImage = new Bitmap(open.FileName);

            }
        }

        private void change_screen_saver_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                screensaver.BackgroundImage = new Bitmap(open.FileName);

            }
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                theme.BackgroundImage = new Bitmap(open.FileName);

            }
        }

        private void save_apply_Click(object sender, EventArgs e)
        {
           
        }
    }
}
