namespace TestProject1;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestFirst()
    {
        double a = 4;
        double b = 5;

        double result = a * b;

        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void TestSecond()
    {
        double a = 0;
        double b = 5;

        double result = a * b;

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestThird()
    {
        double r = 1;
        double result = Math.PI * r * r;
        Assert.IsTrue(result > 3.14 && result < 3.15);
    }

    [TestMethod]
    public void TestFourth()
    {
        double r = 3;
        double result = Math.PI * r * r;
        Assert.IsTrue(result > 28 && result < 29);
    }

    [TestMethod]
    public void TestFifth()
    {
        double r = 0;
        double result = Math.PI * r * r;
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestSixth()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double p = (a + b + c) / 2;
        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestSeventh()
    {
        double a = 5;
        double b = 5;
        double c = 5;
        double p = (a + b + c) / 2;
        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Assert.IsTrue(result > 10 && result < 11);
    }

    [TestMethod]
    public void TestEighth()
    {
        double a = 100;
        double b = 200;
        double result = a * b;
        Assert.AreEqual(20000, result);
    }

    [TestMethod]
    public void TestNinth()
    {
        double r = 2.5;
        double result = Math.PI * r * r;
        Assert.IsTrue(result > 19 && result < 20);
    }
}