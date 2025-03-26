namespace CMS
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridviewattendance = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.rbtabsent = new System.Windows.Forms.RadioButton();
            this.rbtpresent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.picstudent = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbnm = new System.Windows.Forms.ComboBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.paneltitle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewattendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.paneltitle.SuspendLayout();
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
            // gridviewattendance
            // 
            this.gridviewattendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewattendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridviewattendance.Location = new System.Drawing.Point(0, 581);
            this.gridviewattendance.Name = "gridviewattendance";
            this.gridviewattendance.RowHeadersWidth = 51;
            this.gridviewattendance.RowTemplate.Height = 24;
            this.gridviewattendance.Size = new System.Drawing.Size(1200, 185);
            this.gridviewattendance.TabIndex = 12;
            this.gridviewattendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewattendance_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // rbtabsent
            // 
            this.rbtabsent.AutoSize = true;
            this.rbtabsent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtabsent.Location = new System.Drawing.Point(522, 260);
            this.rbtabsent.Name = "rbtabsent";
            this.rbtabsent.Size = new System.Drawing.Size(104, 31);
            this.rbtabsent.TabIndex = 27;
            this.rbtabsent.TabStop = true;
            this.rbtabsent.Text = "Absent";
            this.rbtabsent.UseVisualStyleBackColor = true;
            // 
            // rbtpresent
            // 
            this.rbtpresent.AutoSize = true;
            this.rbtpresent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtpresent.Location = new System.Drawing.Point(387, 260);
            this.rbtpresent.Name = "rbtpresent";
            this.rbtpresent.Size = new System.Drawing.Size(109, 31);
            this.rbtpresent.TabIndex = 26;
            this.rbtpresent.TabStop = true;
            this.rbtpresent.Text = "Present";
            this.rbtpresent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Status";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.labeltitle.Location = new System.Drawing.Point(177, 53);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(290, 38);
            this.labeltitle.TabIndex = 24;
            this.labeltitle.Text = "Attendace Details";
            // 
            // picstudent
            // 
            this.picstudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picstudent.BackgroundImage")));
            this.picstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picstudent.Location = new System.Drawing.Point(688, 53);
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
            this.btndelete.Location = new System.Drawing.Point(498, 348);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 52);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DimGray;
            this.btnupdate.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(114, 348);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(133, 52);
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
            this.btnsave.Location = new System.Drawing.Point(387, 348);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 52);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(72, 192);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(175, 31);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "StudentName";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(72, 125);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(57, 31);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "AID";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(490, 47);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(383, 49);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Attendance Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbnm);
            this.groupBox1.Controls.Add(this.cbid);
            this.groupBox1.Controls.Add(this.rbtabsent);
            this.groupBox1.Controls.Add(this.rbtpresent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labeltitle);
            this.groupBox1.Controls.Add(this.picstudent);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 449);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment_Information";
            // 
            // cbnm
            // 
            this.cbnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnm.FormattingEnabled = true;
            this.cbnm.Location = new System.Drawing.Point(387, 198);
            this.cbnm.Name = "cbnm";
            this.cbnm.Size = new System.Drawing.Size(239, 28);
            this.cbnm.TabIndex = 29;
            // 
            // cbid
            // 
            this.cbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(387, 131);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(239, 28);
            this.cbid.TabIndex = 28;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.ForestGreen;
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1212, 115);
            this.paneltitle.TabIndex = 10;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 770);
            this.Controls.Add(this.gridviewattendance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneltitle);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewattendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridView gridviewattendance;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.RadioButton rbtabsent;
        private System.Windows.Forms.RadioButton rbtpresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox picstudent;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbnm;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Panel paneltitle;
    }
}