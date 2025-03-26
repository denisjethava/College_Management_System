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
    public partial class Dashboard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            student();
            courses();
            faculty();
            enrollment();
        }

        public void student()
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from StudInformation", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count > 0) 
            {
                lblstudent.Text = count.ToString();
            }
            else
            {
                lblstudent.Text = "0";
            }
            con.Close();
        }

        public void courses()
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from SubjectInfo", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcourses.Text = count.ToString();
            }
            else
            {
                lblcourses.Text = "0";
            }
            con.Close();
        }

        public void faculty()
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from FacultyInfo", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblfaculty.Text = count.ToString();
            }
            else
            {
                lblfaculty.Text = "0";
            }
            con.Close();
        }

        public void enrollment()
        {
            con = new SqlConnection("Data Source=DESKTOP-4B7ROGE\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from EnrollmentInfo", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblenrollment.Text = count.ToString();
            }
            else
            {
                lblenrollment.Text = "0";
            }
            con.Close();
        }

    }
}
