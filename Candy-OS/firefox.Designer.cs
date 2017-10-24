namespace Candy_OS
{
    partial class firefox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firefox));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.address = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(993, 568);
            this.webBrowser1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(100, 7);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(363, 22);
            this.address.TabIndex = 2;
            this.address.Text = "Enter web address here like (www.facebook.com)";
            // 
            // go
            // 
            this.go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.Location = new System.Drawing.Point(469, 6);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(38, 23);
            this.go.TabIndex = 3;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(12, 7);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // forward
            // 
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward.Location = new System.Drawing.Point(50, 7);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(32, 23);
            this.forward.TabIndex = 5;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // home
            // 
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Location = new System.Drawing.Point(513, 6);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(50, 23);
            this.home.TabIndex = 6;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // firefox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 568);
            this.Controls.Add(this.home);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.go);
            this.Controls.Add(this.address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "firefox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "firefox";
            this.Load += new System.EventHandler(this.firefox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button home;
    }
}