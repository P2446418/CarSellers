using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsStaffCollection
    {
        //will handle the adding, editing and deleting of customer instances
        //customer will only be able to add their own instance
        //customer will only be able to edit/modify their own instance
        //customer will only be able to delete their own instance
        // - which just sets toDelete to true, doesn't delete straight away in case there are pending orders
        private clsStaff thisStaff;

        public clsStaff getStaff()
        {
            return thisStaff;
        }

        public void setStaff(clsStaff aStaff)
        {
            thisStaff = aStaff;
        }

        public int add(clsStaff aStaff)
        {
            clsDataConnection database = new clsDataConnection();
            database.AddParameter("@FirstName", thisStaff.FirstName);
            database.AddParameter("@Surname", thisStaff.Surname);
            database.AddParameter("@DateOfBirth", thisStaff.DOB);
            database.AddParameter("@MobileNumber", thisStaff.MobileNumber);
            database.AddParameter("@Position", thisStaff.Position);

            return database.Execute("sproc_StaffTable_Insert");
        }

        public void update()
        {
            //updates user data on the database
            clsDataConnection database = new clsDataConnection();

            database.AddParameter("@FirstName", thisStaff.FirstName);
            database.AddParameter("@Surname", thisStaff.Surname);
            database.AddParameter("@DateOfBirth", thisStaff.DOB);
            database.AddParameter("@MobileNumber", thisStaff.MobileNumber);
            database.AddParameter("@Position", thisStaff.Position);

            //as the toDelete field is by default null, the method must consider null to be false
            if (thisStaff.toDelete != true)
            {
                database.AddParameter("@toDelete", false);
            }
            else
            {
                database.AddParameter("@toDelete", true);
            }

            database.Execute("sproc_StaffTable_Update");
        }

        public void delete()
        {
            //need to write procedure to delete row from table
            //just sets the toDelete value to true
            //cannot instantly delete user from database in case they are referenced in current pending orders
            //      which would cause an error within the database

            clsDataConnection database = new clsDataConnection();

            database.AddParameter("@FirstName", thisStaff.FirstName);
            database.AddParameter("@Surname", thisStaff.Surname);
            database.AddParameter("@DateOfBirth", thisStaff.DOB);
            database.AddParameter("@MobileNumber", thisStaff.MobileNumber);
            database.AddParameter("@Position", thisStaff.Position);
            database.AddParameter("@toDelete", true);

            database.Execute("sproc_StaffTable_Update");

        }

    }
}