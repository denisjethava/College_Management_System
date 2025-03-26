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
    public partial class Enrollment : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Enrollment()
        {
            InitializeComponent();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();
            LoadCBData();
            getData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) 
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        public void LoadCBData()
        {
            cmd = new SqlCommand("select sectionnm,section from SectionInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbnm.DataSource = dt;
            cbnm.DisplayMember = "sectionnm";
            cbnm.ValueMember = "section";

            cbsection.DataSource = dt;
            cbsection.DisplayMember = "section";
            cbsection.ValueMember = "sectionnm";
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || cbnm.Text == "" || cbsection.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please Enter Value In The Field", "Blank-Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("select eid from EnrollmentInfo where eid='" + txtid.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Enter Id Is Already Exits", "All-Ready Exits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtid.Clear();
                    txtid.Focus();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into EnrollmentInfo values('" + txtid.Text + "','" + cbnm.Text + "','" + cbsection.Text + "','" + dateTimePicker1.Text + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Insert Record In The Database", "Inser-Recored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                        txtid.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        txtid.Focus();
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
            cmd = new SqlCommand("select * from EnrollmentInfo", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            gridviewenrollment.DataSource = dt;
        }

        private void gridviewenrollment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(gridviewenrollment.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                cmd = new SqlCommand("select eid,enm,esection,edate from EnrollmentInfo where eid='" + id + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetValue(0).ToString();
                    cbnm.Text = dr.GetValue(1).ToString();
                    cbsection.Text = dr.GetValue(2).ToString();
                    dateTimePicker1.Text = dr.GetValue(3).ToString();
                }
                dr.Close();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res = MessageBox.Show("Are You Sure Want To Delete Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridviewenrollment.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmd = new SqlCommand("delete from EnrollmentInfo where eid='" + id + "' ", con);
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
            int id = Convert.ToInt32(txtid.Text);
            cmd = new SqlCommand("update EnrollmentInfo set enm='" + cbnm.Text + "',esection='" + cbsection.Text + "',edate='" + dateTimePicker1.Text + "' where eid='" + id + "' ", con);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
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
