using System;

public class Class1
{
	public Class1()
	{
	}

	[TestMethod]
	public void InstanceOk()
	{
		String name = "bob";
		clsCustomer newCustomer = new clsCustomer(name);
		Assert.IsNotNull(newCustomer);
	}
}
