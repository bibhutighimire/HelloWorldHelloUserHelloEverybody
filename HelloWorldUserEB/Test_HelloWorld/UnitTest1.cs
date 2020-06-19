using NUnit.Framework;
using System;
using System.IO;

namespace Test_HelloWorld
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            HelloWorldUserEB.Program.keyPressed = ConsoleKey.Enter;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        //Citations
        //https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019
        //The unit test below Test_HelloWorld will check the console's output with the expected output
        //Here in our case the expected outputn is "Hello World!" and console's o/p is same.
        //It will compare output and if it doesnot match, test will fail otherwise it will pass. Our test passed!!!
        [Test]
        public void Test_HelloWorld()
        {
            string expected = "Hello World!";
            var sw = new StringWriter();
            Console.SetOut(sw);
            HelloWorldUserEB.Program.Main();
            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }
        //End Citation
    }
}