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
    public partial class Subject : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Subject()
        {
            InitializeComponent();
        }
        private void Subject_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();
            getData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == " " || txtname.Text == "")
            {
                MessageBox.Show("Please Enter Value In The Field", "Blank-Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("select subid from SubjectInfo where subid='" + Convert.ToInt16(txtid.Text) + "' ", con);
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
                    cmd = new SqlCommand("insert into SubjectInfo values('" + Convert.ToInt32(txtid.Text) + "','" + txtname.Text + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Insert Record In The Database", "Inser-Recored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                        txtid.Text = "";
                        txtname.Text = "";
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
            cmd = new SqlCommand("select * from SubjectInfo", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            gridviewsubject.DataSource = dt;
        }

        private void gridviewsubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(gridviewsubject.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                cmd = new SqlCommand("select subid,subname from SubjectInfo where subid='" + id + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetValue(0).ToString();
                    txtname.Text = dr.GetValue(1).ToString();
                }
                dr.Close();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res = MessageBox.Show("Are You Sure Want To Delete Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridviewsubject.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmd = new SqlCommand("delete from SubjectInfo where subid='" + id + "' ", con);
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
            cmd = new SqlCommand("update SubjectInfo set subname='" + txtname.Text + "' where subid='" + txtid.Text + "' ", con);
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
