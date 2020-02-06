using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
	[TestClass]
	public class CustomerTesting
	{
		[TestMethod]
		public void InstanceOk()
		{
			clsCustomer newCustomer = new clsCustomer();
			Assert.IsNotNull(newCustomer);
		}

		[TestMethod]
		public void ActivePropertyOK()
		{
			clsCustomer newCustomer = new clsCustomer();
			String newName = "bob";
			newCustomer.setName(newName);
			Assert.AreEqual(newCustomer.getName(), newName);
		}

		
	}
}
