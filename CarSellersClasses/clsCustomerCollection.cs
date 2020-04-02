using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace CarSellersClasses
{
    class clsCustomerCollection
    {
        //will handle the adding, editing and deleting of customer instances
        //customer will only be able to add their own instance
        //customer will only be able to edit/modify their own instance
        //customer will only be able to delete their own instance
        // - which just sets toDelete to true, doesn't delete straight away in case there are pending orders
        public clsCustomer thisCustomer
        {
            get
            {
                return thisCustomer;
            }
            set
            {
                thisCustomer = value;
            }
        }

        public void add(clsCustomer newCustomer)
        {
            //need to write procedure to insert new data into table
        }

        public void edit()
        {

        }

        public void update()
        {
            //technically the same as edit
            //however edit() updates the class instance, update() updates the database field.
            //this will need a procedure to update the fields in the table
        }

        public void delete()
        {
            //need to write procedure to delete row from table
        }

    }
}
