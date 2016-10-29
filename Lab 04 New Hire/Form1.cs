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

        public void buildTeacherView()
        {
            txtIdNumberTeacher.Visable = true;
            txtFirstNameTeacher.Visable = true;
            txtLastNameTeacher.Visable = true;
            txtRankTeacher.Visable = true;
            txtSallaryTeacher.Visable = true;
        }

        public void buildStudentView()
        {

        }

        public void buildAdministratorView()
        {

        }
    }
}
