using Software.Design.Models;

namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var keyboardDTO = new KeyboardDTO
        {
            manufacturerid = 2,
            name = "something",
            backlight = false,
            colour = "some",
        };

        var keyboard = new Keyboard(keyboardDTO);


        Assert.AreEqual(keyboardDTO.manufacturerid ,keyboard.manufacturerid);
        Assert.AreEqual(keyboardDTO.name ,keyboard.name);
        Assert.AreEqual(keyboardDTO.backlight ,keyboard.backlight);
        Assert.AreEqual(keyboardDTO.colour ,keyboard.colour);
    }

    [TestMethod]
    public void TestMethod2()
    {
        var keyboardDTO = new KeyboardDTO
        {
            manufacturerid = -24521534,
            name = "something",
            backlight = false,
            colour = "some",
        };

        Assert.IsFalse(testid(keyboardDTO.manufacturerid));
    }
    bool testid(int value)
    {
        return value <= 3 && value >= 1;
    }

    [TestMethod]
    public void TestMethod3()
    {
        var keyboardDTO = new KeyboardDTO
        {
            manufacturerid = 2,
            name = "somethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomethingsomething",
            backlight = false,
            colour = "some",
        };
        Assert.IsFalse(testname(keyboardDTO.name));
    }
    bool testname(string test)
    {
        return test.Length <= 30 ; 
    }

    [TestMethod]
    public void TestMethod4()
    {
        var keyboardDTO = new KeyboardDTO
        {
            manufacturerid = 2,
            name = "something",
            backlight = false,
            colour = "somesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesomesome",
        };
        Assert.IsFalse(testname1(keyboardDTO.colour));
    }
    bool testname1(string test)
    {
        return test.Length <= 30 ; 
    }
}