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

        //constructor
        public Person(string hireObj, string id, string fname, string lname, string opt1, string opt2) : base (hireObj, id, fname, lname)
        {
            this.Opt1 = opt1;
            this.Opt2 = opt2;
            this.HireObj = hireObj;

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

    }
}
