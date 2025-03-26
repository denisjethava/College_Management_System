namespace CMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnattendance = new System.Windows.Forms.Button();
            this.btnenroll = new System.Windows.Forms.Button();
            this.btnfaculty = new System.Windows.Forms.Button();
            this.btnsection = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnsubject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(200, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1164, 118);
            this.paneltitle.TabIndex = 3;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(508, 36);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(600, 53);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "College Management System";
            // 
            // btndashboard
            // 
            this.btndashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndashboard.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.Location = new System.Drawing.Point(12, 855);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(170, 48);
            this.btndashboard.TabIndex = 13;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnattendance);
            this.panel1.Controls.Add(this.btnenroll);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.btnfaculty);
            this.panel1.Controls.Add(this.btnsection);
            this.panel1.Controls.Add(this.btnstudent);
            this.panel1.Controls.Add(this.btnsubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 954);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 191);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnattendance
            // 
            this.btnattendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnattendance.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattendance.Location = new System.Drawing.Point(12, 743);
            this.btnattendance.Name = "btnattendance";
            this.btnattendance.Size = new System.Drawing.Size(170, 49);
            this.btnattendance.TabIndex = 19;
            this.btnattendance.Text = "Attendance";
            this.btnattendance.UseVisualStyleBackColor = true;
            this.btnattendance.Click += new System.EventHandler(this.btnattendance_Click);
            // 
            // btnenroll
            // 
            this.btnenroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnenroll.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenroll.Location = new System.Drawing.Point(12, 637);
            this.btnenroll.Name = "btnenroll";
            this.btnenroll.Size = new System.Drawing.Size(170, 49);
            this.btnenroll.TabIndex = 18;
            this.btnenroll.Text = "Enrollment";
            this.btnenroll.UseVisualStyleBackColor = true;
            this.btnenroll.Click += new System.EventHandler(this.btnenroll_Click);
            // 
            // btnfaculty
            // 
            this.btnfaculty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfaculty.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaculty.Location = new System.Drawing.Point(12, 429);
            this.btnfaculty.Name = "btnfaculty";
            this.btnfaculty.Size = new System.Drawing.Size(170, 48);
            this.btnfaculty.TabIndex = 16;
            this.btnfaculty.Text = "Faculty";
            this.btnfaculty.UseVisualStyleBackColor = true;
            this.btnfaculty.Click += new System.EventHandler(this.btnfaculty_Click);
            // 
            // btnsection
            // 
            this.btnsection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsection.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsection.Location = new System.Drawing.Point(12, 537);
            this.btnsection.Name = "btnsection";
            this.btnsection.Size = new System.Drawing.Size(170, 48);
            this.btnsection.TabIndex = 17;
            this.btnsection.Text = "Section";
            this.btnsection.UseVisualStyleBackColor = true;
            this.btnsection.Click += new System.EventHandler(this.btnsection_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnstudent.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Location = new System.Drawing.Point(12, 229);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(170, 48);
            this.btnstudent.TabIndex = 14;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnsubject
            // 
            this.btnsubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsubject.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubject.Location = new System.Drawing.Point(12, 330);
            this.btnsubject.Name = "btnsubject";
            this.btnsubject.Size = new System.Drawing.Size(170, 48);
            this.btnsubject.TabIndex = 15;
            this.btnsubject.Text = "Subject";
            this.btnsubject.UseVisualStyleBackColor = true;
            this.btnsubject.Click += new System.EventHandler(this.btnsubject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(200, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 836);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 954);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSSDIIT-COLLEGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnattendance;
        private System.Windows.Forms.Button btnenroll;
        private System.Windows.Forms.Button btnfaculty;
        private System.Windows.Forms.Button btnsection;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnsubject;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}