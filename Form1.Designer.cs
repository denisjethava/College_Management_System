namespace CMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adpanel = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.adminpic = new System.Windows.Forms.PictureBox();
            this.adpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminpic)).BeginInit();
            this.SuspendLayout();
            // 
            // adpanel
            // 
            this.adpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adpanel.Controls.Add(this.lbltitle);
            this.adpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adpanel.Location = new System.Drawing.Point(0, 1);
            this.adpanel.Name = "adpanel";
            this.adpanel.Size = new System.Drawing.Size(1168, 151);
            this.adpanel.TabIndex = 24;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(456, 47);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(267, 49);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Admin Login";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Red;
            this.btncancle.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancle.Location = new System.Drawing.Point(726, 458);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(134, 51);
            this.btncancle.TabIndex = 31;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Green;
            this.btnlogin.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(938, 458);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(134, 51);
            this.btnlogin.TabIndex = 30;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(938, 354);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(167, 38);
            this.txtpassword.TabIndex = 29;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(938, 256);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 47);
            this.txtusername.TabIndex = 28;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(717, 354);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(143, 38);
            this.lblpassword.TabIndex = 27;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(711, 256);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(149, 38);
            this.lblusername.TabIndex = 26;
            this.lblusername.Text = "Username";
            // 
            // adminpic
            // 
            this.adminpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminpic.ErrorImage = null;
            this.adminpic.Image = ((System.Drawing.Image)(resources.GetObject("adminpic.Image")));
            this.adminpic.Location = new System.Drawing.Point(0, 152);
            this.adminpic.Name = "adminpic";
            this.adminpic.Size = new System.Drawing.Size(630, 441);
            this.adminpic.TabIndex = 25;
            this.adminpic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 594);
            this.Controls.Add(this.adpanel);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.adminpic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.adpanel.ResumeLayout(false);
            this.adpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adpanel;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox adminpic;
    }
}

