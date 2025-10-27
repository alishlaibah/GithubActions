namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void Subtract_Valid_Shlaibah()
	{
		Assert.AreEqual(3, Program.Subtract("5", "2"));
	}

	[TestMethod]
	public void Multiply_Valid_Shlaibah()
	{
		Assert.AreEqual(45, Program.Multiply("5", "7"));
	}

	[TestMethod]
	public void Power_Valid_Shlaibah()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
	}

	[TestMethod]
	public void Divide_Valid_Shlaibah()
	{
		Assert.AreEqual(5, Program.Divide("10", "2"));
	}

}
