using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_04_New_Hire
{
    public static class Validation
    {

        public static bool isValidName(string name)
        {
            if (name.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool isValidGPA(string gpa)
        {
            //try converting string to deicimal

            decimal gpaDecimal = 0;

            try
            {
                gpaDecimal = Convert.ToDecimal(gpa);
            }
            catch (FormatException)
            {
                //Do nothing, will return false anyway
            }
            catch(OverflowException)
            {
                //Do nothing, will return false anyway
            }


            if (gpaDecimal >= 4 || gpaDecimal <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool isValidSelect(string selector)
        {
            if (selector.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isValidID(string ID)
        {
            bool isParsed = false;
            int parsedInt;

            //try parsing to ensure ID contains only numbers
            if (Int32.TryParse(ID, out parsedInt))
            {
                isParsed = true;
            }           

            if (ID.Length == 5 && isParsed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool isValidHourlyRate(string rate)
        {
            decimal rateDecimal = 0;
            try
            {
                rateDecimal = Convert.ToDecimal(rate);
            }
            catch (FormatException)
            {
                //Do nothing, will return false anyway
            }
            catch (OverflowException)
            {
                //Do nothing, will return false anyway
            }


            if (rateDecimal > 0.00m && rateDecimal < 20.00m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool isValidSalary(string salary)
        {
            decimal salaryDecimal = 0;
            try
            {
                salaryDecimal = Convert.ToDecimal(salary);
            }
            catch (FormatException)
            {
                //Do nothing, will return false anyway
            }
            catch (OverflowException)
            {
                //Do nothing, will return false anyway
            }


            if (salaryDecimal > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        


    }
}
