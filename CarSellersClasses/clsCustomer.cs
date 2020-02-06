using System;

namespace CarSellersClasses
{

	public class clsCustomer
	{
		private String name;
		private String surname;
		private DateTime DOB;
		private int PhoneNumber;
		private String email;
		private String Address;
		private Boolean toDelete;

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