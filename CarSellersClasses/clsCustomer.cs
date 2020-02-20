using System;

namespace CarSellersClasses
{

	public class clsCustomer
	{
		public String name;
		public String surname;
		public DateTime DOB;
		public int PhoneNumber;
		public String email;
		public String Address;
		public Boolean toDelete;

		public clsCustomer()
		{
			name = "";
		}

		public void setName(String newName)
		{
			name = newName;
		}

		public String getName() { return name; }
	}
}