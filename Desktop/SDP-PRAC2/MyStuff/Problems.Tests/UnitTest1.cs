using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            Program P = new Program();
            string result1 = P.Prefix("hello");
            string result2 = P.Prefix("");
            string result3 = P.Prefix("what  ....  did you say??  ");

            //Act
            Assert.AreEqual("5,1:hello", result1);
            Assert.AreEqual("0,0:", result2);
            Assert.AreEqual("27,5:what  ....  did you say??  ", result3);
        }
    }
}