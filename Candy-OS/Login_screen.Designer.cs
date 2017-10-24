namespace Candy_OS
{
    partial class Login_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.profile_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.incorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(786, 385);
            this.password.Name = "password";
            this.password.PasswordChar = '.';
            this.password.Size = new System.Drawing.Size(196, 22);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            this.password.MouseHover += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(781, 307);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 29);
            this.username.TabIndex = 1;
            this.username.Text = "Daniel Goncalves";
            // 
            // profile_image
            // 
            this.profile_image.BackColor = System.Drawing.Color.Transparent;
            this.profile_image.BackgroundImage = global::Candy_OS.Properties.Resources.profile;
            this.profile_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_image.Location = new System.Drawing.Point(629, 289);
            this.profile_image.Name = "profile_image";
            this.profile_image.Size = new System.Drawing.Size(131, 126);
            this.profile_image.TabIndex = 2;
            this.profile_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(783, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.White;
            this.enter.BackgroundImage = global::Candy_OS.Properties.Resources.next;
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.Location = new System.Drawing.Point(964, 389);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(16, 14);
            this.enter.TabIndex = 4;
            this.enter.TabStop = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // incorrect
            // 
            this.incorrect.AutoSize = true;
            this.incorrect.BackColor = System.Drawing.Color.Transparent;
            this.incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect.ForeColor = System.Drawing.Color.White;
            this.incorrect.Location = new System.Drawing.Point(783, 366);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(138, 16);
            this.incorrect.TabIndex = 5;
            this.incorrect.Text = "Password is incorrect!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Candy_OS.Properties.Resources.pexels_photo_445109;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 638);
            this.Controls.Add(this.incorrect);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile_image);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox profile_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label incorrect;
    }
}

