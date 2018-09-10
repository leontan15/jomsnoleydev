using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTestAppPrac
{
    class Friend
    {
        // declare variables for Invoice object
        private int yearCount;
        private int dayValue;
        private int mobileNumber;
        private int monthValue;

      

        // auto-implemented property PartNumber
        //public int PartNumber { get; set; }

        // auto-implemented property PartDescription
        public string LastNameText { get; set; }

        public string FirstNameText { get; set; }

        // four-argument constructor
        public Friend (string lastName, string firstName,
           int dayNum, int monthNum, int yearNum, int mobileNum)
        {
            LastNameText = lastName;
            FirstNameText = firstName;
            DayCount = dayNum;
            MonthCount = monthNum;
            yearCount = yearNum;
            mobileNumber = mobileNum;
        }

        // property for day value; ensures value within range
        public int DayCount
        {
            get
            {
                return dayValue;
            }
            set
            {
                //&& value <= 31
                if (value > 1 || value < 31 ) // determine whether quantity is positive
                {
                    dayValue = value; // valid quantity assigned
                }

               else
               throw new ArgumentOutOfRangeException("Day ", value, "Value must be between 1 - 31");
            }
        }
        // property for day value; ensures value is within range
        public int MonthCount
        {
            get
            {
                return monthValue;
            }
            set
            {
                if (value > 1 ) // determine whether quantity is positive
                {
                    monthValue = value; // valid quantity assigned
                }

               else
               throw new ArgumentOutOfRangeException("Month ", value, "Value must be between 1 - 12");
            }
        }

        

        // return string containing the fields in the Invoice in a nice format;
        // left justify each field, and give large enough spaces so
        // all the columns line up
        public override string ToString() =>
           $"{LastNameText,-20} {FirstNameText,-20} {mobileNumber,-9} ";
    }

}
