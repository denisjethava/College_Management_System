namespace CMS
{
    partial class Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.picstudent = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.gridviewsubject = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.paneltitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsubject)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.DarkMagenta;
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1212, 115);
            this.paneltitle.TabIndex = 4;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(490, 47);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(324, 49);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Subjects Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeltitle);
            this.groupBox1.Controls.Add(this.picstudent);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 458);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subjects_Information";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.Purple;
            this.labeltitle.Location = new System.Drawing.Point(175, 91);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(268, 38);
            this.labeltitle.TabIndex = 24;
            this.labeltitle.Text = "Subjects Details";
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
            this.btndelete.Location = new System.Drawing.Point(494, 335);
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
            this.btnupdate.Location = new System.Drawing.Point(108, 335);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(135, 52);
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
            this.btnsave.Location = new System.Drawing.Point(383, 335);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 52);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(383, 252);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 38);
            this.txtname.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(383, 181);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(239, 38);
            this.txtid.TabIndex = 11;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(68, 259);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(169, 31);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "SubjectName";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(68, 188);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(123, 31);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "SubjectId";
            // 
            // gridviewsubject
            // 
            this.gridviewsubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewsubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridviewsubject.Location = new System.Drawing.Point(13, 603);
            this.gridviewsubject.Name = "gridviewsubject";
            this.gridviewsubject.RowHeadersWidth = 51;
            this.gridviewsubject.RowTemplate.Height = 24;
            this.gridviewsubject.Size = new System.Drawing.Size(1187, 161);
            this.gridviewsubject.TabIndex = 6;
            this.gridviewsubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewsubject_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 770);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridviewsubject);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox picstudent;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView gridviewsubject;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}