using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_New_Hire
{

    public class NewHire
    {

        public string id;
        public string fname;
        public string lname;
        public string obj;


        //boolean to prevent returning of data if a field isn't valid
        public bool errorOccored = false;

        public NewHire()
        { }

        public NewHire(string obj, string id, string fname, string lname)
        {
            //Doesn't need validation
            this.Obj = obj;

            if (Validation.isValidID(id))
            {
                this.Id = id;
            }
            else
            {
                MessageBox.Show("ID is not valid!", "Error!");
                errorOccored = true;
            }
            
            if (Validation.isValidName(fname))
            {
                this.Fname = fname;
            }
            else
            {
                MessageBox.Show("First Name is not valid!", "Error!");
                errorOccored = true;
            }

            if (Validation.isValidName(lname))
            {
                this.Lname = lname;
            }
            else
            {
                MessageBox.Show("Last Name is not valid!", "Error!");
                errorOccored = true;
            }

        }
        public string Obj
        {
            get
            {
                return obj;
            }
            set
            {
                obj = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Fname
        {

            get
            {

                return fname;

            }
            set
            {

                fname = value;

            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public virtual string displayinfo()
        {
            if (errorOccored == true)
            {
                return "Error has occured";
            }
            else
            {
                return "The object type is " + obj + "\n" + "The ID is " + id + "\n" + "The name is " + fname + "\n" + "The name is " + lname;
            }
            
        }
    }


}

