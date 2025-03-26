using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnstudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();    
            student.ShowDialog();
        }

        private void btnsubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.ShowDialog();
            
        }

        private void btnfaculty_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();    
            faculty.ShowDialog();
        }

        private void btnsection_Click(object sender, EventArgs e)
        {
            Section section = new Section();    
            section.ShowDialog();
        }

        private void btnenroll_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.ShowDialog();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.ShowDialog();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
