using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_New_Hire
{
    //Didnt know how to implement more than one base class for administration, teacher, and student
    //Just used 1 base class from the example instead
    public class Person : NewHire
    {
        private string opt1;
        private string opt2;
        private string hireObj;

        //boolean to prevent returning of data if a field isn't valid
        private bool errorOccured = false;


        //constructor
        public Person(string hireObj, string id, string fname, string lname, string opt1, string opt2) : base(hireObj, id, fname, lname)
        {
            this.HireObj = hireObj;

            if (hireObj == "Teacher")
            {
                if (Validation.isValidSelect(opt1))
                {
                    this.Opt1 = opt1;
                }
                else
                {
                    MessageBox.Show("Invalid select", "Error");
                    errorOccured = true;
                }


                if (Validation.isValidSalary(opt2))
                {
                    this.Opt2 = opt2;
                }
                else
                {
                    MessageBox.Show("Invalid salary", "Error");
                    errorOccured = true;
                }

            }
            else if (hireObj == "Student")
            {
                if (Validation.isValidSelect(opt1))
                {
                    this.Opt1 = opt1;
                }
                else
                {
                    MessageBox.Show("Invalid select", "Error");
                    errorOccured = true;
                }

                if (Validation.isValidGPA(opt2))
                {
                    this.Opt2 = opt2;
                }
                else
                {

                    MessageBox.Show("Invalid GPA", "Error");
                    errorOccured = true;
                }



            }
            else if (hireObj == "Administrator")
            {
                if (Validation.isValidSelect(opt1))
                {
                    this.Opt1 = opt1;
                }
                else
                {
                    MessageBox.Show("Invalid select", "Error");
                    errorOccured = true;
                }

                if (Validation.isValidHourlyRate(opt2))
                {
                    this.Opt2 = opt2;
                }
                else
                {
                    MessageBox.Show("Invalid hourly rate", "Error");
                    errorOccured = true;
                }
            }



        }



        //Properties
        public string Opt1
        {
            get
            {
                return opt1;
            }
            set
            {
                opt1 = value;
            }
        }

        public string Opt2
        {
            get
            {
                return opt2;
            }
            set
            {
                opt2 = value;
            }
        }

        public string HireObj
        {
            get
            {
                return hireObj;
            }
            set
            {
                hireObj = value;
            }
        }

        //Overide method which determins what option 1 and option 2 is
        public override string displayinfo()
        {
            if (!errorOccured)
            {


                if (this.HireObj == "Teacher")
                {
                    return base.displayinfo() + "\n" + "Rank: " + this.Opt1 + "\n" + "Salary: " + this.Opt2;
                }
                else if (this.HireObj == "Student")
                {
                    return base.displayinfo() + "\n" + "Major: " + this.Opt1 + "\n" + "GPA: " + this.Opt2;
                }
                else if (this.HireObj == "Administrator")
                {
                    return base.displayinfo() + "\n" + "Department: " + this.Opt1 + "\n" + "Hourly Rate: " + this.Opt2;
                }
                else
                {
                    MessageBox.Show("Contact support", "ERROR!");
                    return "ERROR";
                }

            }
            else
            {
                return "An error has occured preventing the system from displaying information! \n\nPlease go back and fix your error!";
            }

        }

    }
}
