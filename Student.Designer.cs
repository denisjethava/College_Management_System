namespace CMS
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridviewstudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtfemale = new System.Windows.Forms.RadioButton();
            this.rbtmale = new System.Windows.Forms.RadioButton();
            this.picstudent = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblmo = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).BeginInit();
            this.paneltitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // gridviewstudent
            // 
            this.gridviewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridviewstudent.Location = new System.Drawing.Point(13, 713);
            this.gridviewstudent.Name = "gridviewstudent";
            this.gridviewstudent.RowHeadersWidth = 51;
            this.gridviewstudent.RowTemplate.Height = 24;
            this.gridviewstudent.Size = new System.Drawing.Size(1187, 193);
            this.gridviewstudent.TabIndex = 5;
            this.gridviewstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewstudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(414, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 27);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 1, 21, 52, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // rbtfemale
            // 
            this.rbtfemale.AutoSize = true;
            this.rbtfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtfemale.Location = new System.Drawing.Point(531, 304);
            this.rbtfemale.Name = "rbtfemale";
            this.rbtfemale.Size = new System.Drawing.Size(122, 33);
            this.rbtfemale.TabIndex = 25;
            this.rbtfemale.TabStop = true;
            this.rbtfemale.Text = "Female";
            this.rbtfemale.UseVisualStyleBackColor = true;
            // 
            // rbtmale
            // 
            this.rbtmale.AutoSize = true;
            this.rbtmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtmale.Location = new System.Drawing.Point(414, 304);
            this.rbtmale.Name = "rbtmale";
            this.rbtmale.Size = new System.Drawing.Size(91, 33);
            this.rbtmale.TabIndex = 24;
            this.rbtmale.TabStop = true;
            this.rbtmale.Text = "Male";
            this.rbtmale.UseVisualStyleBackColor = true;
            // 
            // picstudent
            // 
            this.picstudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picstudent.BackgroundImage")));
            this.picstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picstudent.Location = new System.Drawing.Point(688, 92);
            this.picstudent.Name = "picstudent";
            this.picstudent.Size = new System.Drawing.Size(483, 387);
            this.picstudent.TabIndex = 23;
            this.picstudent.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(536, 515);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 52);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DimGray;
            this.btnupdate.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(135, 515);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 52);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(414, 515);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 52);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(414, 441);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(239, 38);
            this.txtemail.TabIndex = 15;
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(414, 369);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(239, 38);
            this.txtmobile.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(414, 163);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 38);
            this.txtname.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(414, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(239, 38);
            this.txtid.TabIndex = 11;
            // 
            // lblmo
            // 
            this.lblmo.AutoSize = true;
            this.lblmo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmo.Location = new System.Drawing.Point(99, 376);
            this.lblmo.Name = "lblmo";
            this.lblmo.Size = new System.Drawing.Size(130, 31);
            this.lblmo.TabIndex = 10;
            this.lblmo.Text = "MobileNo";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(99, 444);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(169, 31);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "StudentEmail";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(99, 304);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(98, 31);
            this.lblgender.TabIndex = 3;
            this.lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(99, 240);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(62, 31);
            this.lbldob.TabIndex = 2;
            this.lbldob.Text = "Dob";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(99, 170);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(175, 31);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "StudentName";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(99, 99);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(129, 31);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "StudentId";
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1211, 115);
            this.paneltitle.TabIndex = 3;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(490, 47);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(335, 49);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Students Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeltitle);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rbtfemale);
            this.groupBox1.Controls.Add(this.rbtmale);
            this.groupBox1.Controls.Add(this.picstudent);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblmo);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lbldob);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 586);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students_Information";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labeltitle.Location = new System.Drawing.Point(213, 37);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(271, 38);
            this.labeltitle.TabIndex = 27;
            this.labeltitle.Text = "Students Details";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 910);
            this.Controls.Add(this.gridviewstudent);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).EndInit();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridView gridviewstudent;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtfemale;
        private System.Windows.Forms.RadioButton rbtmale;
        private System.Windows.Forms.PictureBox picstudent;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblmo;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltitle;
    }
}