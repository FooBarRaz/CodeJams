using System;
using System.Linq;

namespace CodeJam___MinimumScalarProduct
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string smallDataSet = @"C:\Users\Raz\Downloads\A-small-practice (4).in";
            string largeDataSet = @"C:\Users\Raz\Downloads\A-large-practice (1).in";
            string[] lines =
                TestCaseReader.TestCaseReader.ReadAllLines(largeDataSet);

            string outputFile = @"C:\temp\minscalarvectoroutput.txt";

            // First Line is number of test cases
            var numberOfTestCases = int.Parse(lines[0]);
            var output = new string[numberOfTestCases];
            for (int i = 1, t = 0; i < lines.Length; i += 3)
            {
                int size = int.Parse(lines[i]);
                int[] xVectors = lines[i + 1].Split(' ').Select(int.Parse).ToArray();
                int[] yVectors = lines[i + 2].Split(' ').Select(int.Parse).ToArray();


                var msv = MinumumScalarProduct.GetMinimumScalarVector(xVectors, yVectors);
                output[t++] = "Case #" + t + ": " + msv;
            }

            TestCaseReader.FileWriter.WriteAllLines(@outputFile, output);
        }
    }
}

