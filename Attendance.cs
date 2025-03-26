using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class Attendance : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();
            LoadDataCB();
            getData();
        }

        public void LoadDataCB()
        {
            cmd = new SqlCommand("select studid,studnm from StudInformation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbid.DataSource = dt;
            cbid.DisplayMember = "studid";
            cbid.ValueMember = "studnm";

            cbnm.DataSource = dt;
            cbnm.DisplayMember = "studnm";
            cbnm.ValueMember = "studid";
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbid.Text == "" || cbnm.Text == "" || !rbtpresent.Checked && !rbtabsent.Checked)   
            {
                MessageBox.Show("Please Enter Values In The Field", "Blank-Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("select aid,anm from AttendanceInfo where aid='" + cbid.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) 
                {
                    MessageBox.Show("Enter Id Is Already Exits", "All-Ready Exits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbid.Focus();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into AttendanceInfo values('" + cbid.Text + "','" + cbnm.Text + "','" + (rbtpresent.Checked == true ? "Present" : "Absent") + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Insert Record In The Database", "Inser-Recored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                        rbtpresent.Checked = false;
                        rbtabsent.Checked = false;
                        cbid.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error In Insert Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void getData()
        {
            cmd = new SqlCommand("select * from AttendanceInfo", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            gridviewattendance.DataSource = dt;
        }

        private void gridviewattendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(gridviewattendance.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                cmd = new SqlCommand("select aid,anm,status from AttendanceInfo where aid='" + id + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cbid.Text = dr.GetValue(0).ToString();
                    cbnm.Text = dr.GetValue(1).ToString();

                    if (dr.GetValue(2).ToString() == "Present")
                        rbtpresent.Checked = true;
                    else
                        rbtabsent.Checked = true;
                }
                dr.Close();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res = MessageBox.Show("Are You Sure Want To Delete Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridviewattendance.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmd = new SqlCommand("delete from AttendanceInfo where aid='" + id + "' ", con);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Record Delete Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                    }
                    else
                    {
                        MessageBox.Show("Error In Delete Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbid.Text);
            cmd = new SqlCommand("update AttendanceInfo set anm='" + cbnm.Text + "',status='" + (rbtpresent.Checked == true ? "Present" : "Absent") + "' where aid='" + cbid.Text + "' ", con);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Record Update Successfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getData();
            }
            else
            {
                MessageBox.Show("Error In Update Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
