using System;

namespace CarSellersClasses
{
    public class clsStaff
    {
        public bool InOffice { get; set; }
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string Position { get; set; }

        public bool Find(string FirstName)
        {
            FirstName = "Jeff";
            return true;
        }

        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
    }
}