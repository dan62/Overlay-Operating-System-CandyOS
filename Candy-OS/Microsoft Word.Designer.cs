namespace Candy_OS
{
    partial class Microsoft_Word
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
            this.label1 = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.office)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // office
            // 
            this.office.BackgroundImage = global::Candy_OS.Properties.Resources.office;
            this.office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.office.Location = new System.Drawing.Point(24, 15);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(79, 32);
            this.office.TabIndex = 1;
            this.office.TabStop = false;
            // 
            // Microsoft_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(144)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.office);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Microsoft_Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft_Word";
            ((System.ComponentModel.ISupportInitialize)(this.office)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox office;
    }
}