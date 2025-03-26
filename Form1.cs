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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;

            cmd=new SqlCommand("select * from AdminLogin where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Home h1 = new Home();
                h1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Wrong!","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtusername.ResetText();
                txtpassword.ResetText();
            }
            con.Close();
           /* Home h1 = new Home();
            h1.Show();
            this.Hide();*/
        }
        
        private void btncancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
