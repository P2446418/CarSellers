using System;

namespace CarSellersClasses
{

	public class clsCustomer
	{
        public String name = "temp";
		public String surname;
		public DateTime DOB;
		public int PhoneNumber;
		public String email;
		public String Address;
		public Boolean toDelete;

        //constructor
        public clsCustomer()
		{
			name = "";
		}

        //get set methods (WIP)
		public void setName(String newName)
		{
			name = newName;
		}

		public String getName() { return name; }

        //find method
       

	}
}