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
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();
            getData();

            gridviewstudent.Columns["studid"].HeaderText = "StudId";
            gridviewstudent.Columns["studnm"].HeaderText = "StudName";
            gridviewstudent.Columns["dob"].HeaderText = "Dob";
            gridviewstudent.Columns["gender"].HeaderText = "Gender";
            gridviewstudent.Columns["phone"].HeaderText = "Mobile";
            gridviewstudent.Columns["email"].HeaderText = "Email";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if(e.KeyCode == Keys.Back)
              {
                  dateTimePicker1.CustomFormat = "";
              }*/
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || dateTimePicker1.Text == "" || txtmobile.Text == "" || txtemail.Text == "") 
            {
                MessageBox.Show("Please Enter Value In The Field", "Blank-Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("select studid from StudInformation where studid='" + Convert.ToInt16(txtid.Text) + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Enter Id Is Already Exits", "All-Ready Exits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtid.Clear();
                    txtid.Focus();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into StudInformation values('" + Convert.ToInt16(txtid.Text) + "','" + txtname.Text + "','" + dateTimePicker1.Text + "','" + (rbtmale.Checked == true ? "Male" : "Female") + "','"+txtmobile.Text+"','"+txtemail.Text+"')",con);
                    int res = cmd.ExecuteNonQuery();
                    getData();
                    if(res > 0)
                    {
                        MessageBox.Show("Insert Record In The Database", "Inser-Recored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtid.Text = "";
                        txtname.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        rbtmale.Checked = false;
                        rbtfemale.Checked = false;
                        txtmobile.Text = "";
                        txtemail.Text = "";
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
            cmd = new SqlCommand("select * from StudInformation",con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            gridviewstudent.DataSource = dt;
        }

        private void gridviewstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(gridviewstudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                cmd = new SqlCommand("select studid,studnm,dob,gender,phone,email from StudInformation where studid='" + id + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetValue(0).ToString(); ;
                    txtname.Text = dr.GetValue(1).ToString(); ;
                    dateTimePicker1.Text = dr.GetValue(2).ToString(); ;
                    if (dr.GetValue(3).ToString() == "Male")
                        rbtmale.Checked = true;
                    else
                        rbtfemale.Checked = true;
                    txtmobile.Text = dr.GetValue(4).ToString();
                    txtemail.Text = dr.GetValue(5).ToString();
                }
                dr.Close();
            }
            else if(e.ColumnIndex == 1)
            {
                DialogResult res = MessageBox.Show("Are You Sure Want To Delete Record","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(res==DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridviewstudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmd = new SqlCommand("delete from StudInformation where studid='" + id + "' ",con);
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
            cmd = new SqlCommand("update StudInformation set studnm='" + txtname.Text + "',dob='" + dateTimePicker1.Text + "',gender='" + (rbtmale.Checked == true ? "Male" : "Female") + "',phone='" + txtmobile.Text + "',email='" + txtemail.Text + "' where studid='" + txtid.Text + "' ", con);
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

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
