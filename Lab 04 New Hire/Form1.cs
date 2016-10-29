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


        //declare selector to determin which 'hire' is going to happen (Administration, Student, or Teacher)
        public string hireObject;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person p = new Person("", "", "", "", "", "");
            if (hireObject == "Teacher")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, txtRankTeacher.Text, txtSallaryTeacher.Text);
                MessageBox.Show(p.displayinfo());
            }
            else if (hireObject == "Student")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, txtMajorStudent.Text, txtGpaStudent.Text);
                MessageBox.Show(p.displayinfo());
            }
            else if (hireObject == "Administrator")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, txtDepartmentAdministration.Text, txtHourlyRateAdministration.Text);
                MessageBox.Show(p.displayinfo());
            }
            else
            {
                MessageBox.Show("System has malfunctioned!", "ERROR!");
            }

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            buildTeacherView();
            hireObject = "Teacher";

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            buildStudentView();
            hireObject = "Student";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            buildAdministratorView();
            hireObject = "Administrator";
        }



        //Button to clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        //Button to exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }































        //methods to clean up and change the form according to object selection

        public void clearFields()
        {
            txtDepartmentAdministration.Text = "";
            txtFirstName.Text = "";
            txtGpaStudent.Text = "";
            txtHourlyRateAdministration.Text = "";
            txtId.Text = "";
            txtLastName.Text = "";
            txtMajorStudent.Text = "";
            txtRankTeacher.Text = "";
            txtSallaryTeacher.Text = "";
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
