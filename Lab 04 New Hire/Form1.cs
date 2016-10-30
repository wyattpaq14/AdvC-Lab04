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


        //declare selector to determine which 'hire' is going to happen (Administration, Student, or Teacher)
        public string hireObject;


        //Define lists to store items based on which object
        //For example, majors will store networking, software, and game development
        public List<string> lstMajors = new List<string> { "Software Engineering", "Network Engineering", "Game Development" };
        public List<string> lstDept = new List<string> { "Maintenance", "Security", "Clerical" };
        public List<string> lstRank = new List<string> { "Professor", "Associate Professor", "Adjunct Faculty" };

        //String to keep track of what is selected in the combo box
        //Using combobox to make validation easier
        public string selectedIndex;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //retreive shit from combobox
            selectedIndex = cbOption1.Text;

            //Define default data model
            Person p = new Person("Student", "12345", "John", "Smith", "Game Development", "3.5");
            if (hireObject == "Teacher")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, selectedIndex, txtSallaryTeacher.Text);
                MessageBox.Show(p.displayinfo());
            }
            else if (hireObject == "Student")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, selectedIndex, txtGpaStudent.Text);
                MessageBox.Show(p.displayinfo());
            }
            else if (hireObject == "Administrator")
            {
                p = new Person(hireObject, txtId.Text, txtFirstName.Text, txtLastName.Text, selectedIndex, txtHourlyRateAdministration.Text);
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
            txtFirstName.Text = "";
            txtGpaStudent.Text = "";
            txtHourlyRateAdministration.Text = "";
            txtId.Text = "";
            txtLastName.Text = "";
            txtSallaryTeacher.Text = "";
        }


        public void buildTeacherView()
        {
            removeMiscFields();
            buildMainForm();
            txtSallaryTeacher.Visible = true;
            lblOpt1.Text = "Rank: ";
            lblOption2.Text = "Salary: ";

            //Make combobox visiable
            cbOption1.Visible = true;

            //Bind combobox to list
            cbOption1.DataSource = lstRank;
        }

        public void buildStudentView()
        {
            removeMiscFields();
            buildMainForm();
            txtGpaStudent.Visible = true;
            lblOpt1.Text = "Major: ";
            lblOption2.Text = "GPA: ";

            //Make combobox visiable
            cbOption1.Visible = true;


            //Bind combobox to list
            cbOption1.DataSource = lstMajors;

        }

        public void buildAdministratorView()
        {
            removeMiscFields();
            buildMainForm();
            txtHourlyRateAdministration.Visible = true;
            lblOpt1.Text = "Department: ";
            lblOption2.Text = "Hourly Rate: ";

            //Make combobox visiable
            cbOption1.Visible = true;

            //Bind combobox to list
            cbOption1.DataSource = lstDept;

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
            txtHourlyRateAdministration.Visible = false;
            txtGpaStudent.Visible = false;
            txtSallaryTeacher.Visible = false;
            cbOption1.Visible = false;
        }


    }
}
