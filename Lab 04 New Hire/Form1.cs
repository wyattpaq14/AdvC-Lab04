using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_New_Hire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnTeacher_Click(object sender, EventArgs e)
        {
            buildTeacherView();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            buildStudentView();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            buildAdministratorView();
        }









































        public void buildTeacherView()
        {
            removeMiscFields();
            buildMainForm();
            txtRankTeacher.Visible = true;
            txtSallaryTeacher.Visible = true;
            lblOpt1.Text = "Rank: ";
            lblOption2.Text = "Salary: ";
        }

        public void buildStudentView()
        {
            removeMiscFields();
            buildMainForm();
            txtMajorStudent.Visible = true;
            txtGpaStudent.Visible = true;
            lblOpt1.Text = "Major: ";
            lblOption2.Text = "GPA: ";

        }

        public void buildAdministratorView()
        {
            removeMiscFields();
            buildMainForm();
            txtDepartmentAdministration.Visible = true;
            txtHourlyRateAdministration.Visible = true;
            lblOpt1.Text = "Department: ";
            lblOption2.Text = "Hourly Rate: ";

        }


        public void buildMainForm()
        {
            lblFirstName.Visible = true;
            lblId.Visible = true;
            lblLastName.Visible = true;
            txtFirstName.Visible = true;
            txtId.Visible = true;
            txtLastName.Visible = true;
            lblOpt1.Visible = true;
            lblOption2.Visible = true;
        }

        public void removeMiscFields()
        {
            txtDepartmentAdministration.Visible = false;
            txtHourlyRateAdministration.Visible = false;
            txtMajorStudent.Visible = false;
            txtGpaStudent.Visible = false;
            txtRankTeacher.Visible = false;
            txtSallaryTeacher.Visible = false;
        }

        
    }
}
