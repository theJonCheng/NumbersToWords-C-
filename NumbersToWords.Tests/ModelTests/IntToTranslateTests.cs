using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;


namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersTests
  {
    // Tests go here
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfNumbers_Numbers()
    {
      Numbers newNumbers = new Numbers("456");
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

    [TestMethod]
    public void GetUserInput_ReturnsUserInput_String()
    {
      string text = "123";
      Numbers newNumbers = new Numbers(text);
      string returnedText = newNumbers.UserInput;
      Assert.AreEqual(text, returnedText);
    }

  }
}