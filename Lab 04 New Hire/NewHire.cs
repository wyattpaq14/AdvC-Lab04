using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_New_Hire
{

    public class NewHire
    {

        public string id;
        public string fname;
        public string lname;
        public string obj;

        public NewHire()
        { }

        public NewHire(string obj, string id, string fname, string lname)
        {
            this.Obj = obj;
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;

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
            return "The object type is " + obj + "\n" + "The ID is " + id + "\n" + "The name is " + fname + "\n" + "The name is " + lname;
        }
    }


}

