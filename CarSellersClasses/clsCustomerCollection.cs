using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsCustomerCollection
    {
        //will handle the adding, editing and deleting of customer instances
        //customer will only be able to add their own instance
        //customer will only be able to edit/modify their own instance
        //customer will only be able to delete their own instance
        // - which just sets toDelete to true, doesn't delete straight away in case there are pending orders
        private clsCustomer thisCustomer;

        public clsCustomer getCustomer()
        {
            return thisCustomer;
        }

        public void setCustomer(clsCustomer newCustomer)
        {
            thisCustomer = newCustomer;
        }

        public int add(clsCustomer newCustomer)
        {
            clsDataConnection database = new clsDataConnection();
            database.AddParameter("@FirstName", thisCustomer.name);
            database.AddParameter("@SurName", thisCustomer.surname);
            database.AddParameter("@DateOfBirth", thisCustomer.DOB);
            database.AddParameter("@PhoneNumber", thisCustomer.PhoneNumber);
            database.AddParameter("@Email", thisCustomer.email);
            database.AddParameter("@Address", thisCustomer.Address);

            return database.Execute("sproc_CustomerTable_Insert");
        }

        public void update()
        {
            //updates user data on the database
            clsDataConnection database = new clsDataConnection();

            database.AddParameter("@FirstName", thisCustomer.name);
            database.AddParameter("@SurName", thisCustomer.surname);
            database.AddParameter("@DateOfBirth", thisCustomer.DOB);
            database.AddParameter("@PhoneNumber", thisCustomer.PhoneNumber);
            database.AddParameter("@Email", thisCustomer.email);
            database.AddParameter("@Address", thisCustomer.Address);

            //as the toDelete field is by default null, the method must consider null to be false
            if (thisCustomer.toDelete != true)
            {
                database.AddParameter("@toDelete", false);
            }
            else
            {
                database.AddParameter("@toDelete", true);
            }

            database.Execute("sproc_CustomerTable_Update");
        }

        public void delete()
        {
            //need to write procedure to delete row from table
            //just sets the toDelete value to true
            //cannot instantly delete user from database in case they are referenced in current pending orders
            //      which would cause an error within the database

            clsDataConnection database = new clsDataConnection();

            database.AddParameter("@FirstName", thisCustomer.name);
            database.AddParameter("@SurName", thisCustomer.surname);
            database.AddParameter("@DateOfBirth", thisCustomer.DOB);
            database.AddParameter("@PhoneNumber", thisCustomer.PhoneNumber);
            database.AddParameter("@Email", thisCustomer.email);
            database.AddParameter("@Address", thisCustomer.Address);
            database.AddParameter("@toDelete", true);

            database.Execute("sproc_CustomerTable_Update");

        }

    }
}
