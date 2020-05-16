using System;

public class testStock
{
	public testStock()
	{
	}

    public void instanceOk()
    {
        clsStock stock = new clsStock();
        Assert.IsNotNull(stock);
    }
}
