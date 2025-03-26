namespace CMS
{
    partial class Enrollment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollment));
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbsection = new System.Windows.Forms.ComboBox();
            this.cbnm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.picstudent = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridviewenrollment = new System.Windows.Forms.DataGridView();
            this.paneltitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewenrollment)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.Crimson;
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1212, 115);
            this.paneltitle.TabIndex = 9;
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
            this.lbltitle.Text = "Enrollment Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(387, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 38);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbsection);
            this.groupBox1.Controls.Add(this.cbnm);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblsection);
            this.groupBox1.Controls.Add(this.labeltitle);
            this.groupBox1.Controls.Add(this.picstudent);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 462);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment_Information";
            // 
            // cbsection
            // 
            this.cbsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsection.FormattingEnabled = true;
            this.cbsection.Location = new System.Drawing.Point(387, 261);
            this.cbsection.Name = "cbsection";
            this.cbsection.Size = new System.Drawing.Size(239, 28);
            this.cbsection.TabIndex = 31;
            // 
            // cbnm
            // 
            this.cbnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnm.FormattingEnabled = true;
            this.cbnm.Location = new System.Drawing.Point(387, 198);
            this.cbnm.Name = "cbnm";
            this.cbnm.Size = new System.Drawing.Size(239, 28);
            this.cbnm.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "EnrollDate";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsection.Location = new System.Drawing.Point(72, 258);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(100, 31);
            this.lblsection.TabIndex = 25;
            this.lblsection.Text = "Section";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.Crimson;
            this.labeltitle.Location = new System.Drawing.Point(182, 53);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(299, 38);
            this.labeltitle.TabIndex = 24;
            this.labeltitle.Text = "Enrollment Details";
            // 
            // picstudent
            // 
            this.picstudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picstudent.BackgroundImage")));
            this.picstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picstudent.Location = new System.Drawing.Point(686, 53);
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
            this.btndelete.Location = new System.Drawing.Point(498, 377);
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
            this.btnupdate.Location = new System.Drawing.Point(111, 377);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(136, 52);
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
            this.btnsave.Location = new System.Drawing.Point(387, 377);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 52);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(387, 125);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(239, 38);
            this.txtid.TabIndex = 11;
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
            this.lblid.Size = new System.Drawing.Size(50, 31);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "EId";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // gridviewenrollment
            // 
            this.gridviewenrollment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewenrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewenrollment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridviewenrollment.Location = new System.Drawing.Point(12, 584);
            this.gridviewenrollment.Name = "gridviewenrollment";
            this.gridviewenrollment.RowHeadersWidth = 51;
            this.gridviewenrollment.RowTemplate.Height = 24;
            this.gridviewenrollment.Size = new System.Drawing.Size(1169, 185);
            this.gridviewenrollment.TabIndex = 11;
            this.gridviewenrollment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewenrollment_CellContentClick);
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 770);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridviewenrollment);
            this.Name = "Enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewenrollment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox picstudent;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridView gridviewenrollment;
        private System.Windows.Forms.ComboBox cbnm;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbsection;
    }
}