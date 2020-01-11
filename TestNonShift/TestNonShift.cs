using System;
using System.IO;
using static System.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NonShift;

namespace TestNonShift
{
    [TestClass]
    public class TestNonShift
    {
        [TestMethod]
        public void TestOfTest()
        {
            AssertEqualStdIO("TestOfTest_input.txt",
                             "TestOfTest_output.txt");
        }

        private void AssertEqualStdIO(string inputFileName, string outputFileName)
        {
            inputFileName = @"C:\Users\t_kitada\source\repos\NonShift\TestNonShift\stdIO\" + inputFileName;
            outputFileName = @"C:\Users\t_kitada\source\repos\NonShift\TestNonShift\stdIO\" + outputFileName;
            using (var input = new StreamReader(inputFileName))
            using (var output = new StringWriter())
            {
                SetIn(input);
                SetOut(output);

                Program.Main(new string[] { "test"});

                Assert.AreEqual(File.ReadAllText(outputFileName), output.ToString());
            }
        }
    }
}
