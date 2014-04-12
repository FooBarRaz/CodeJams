namespace TestCaseReader
{
    public class TestCaseReader
    {
        public static string[] ReadAllLines(string filename)
        {
            return System.IO.File.ReadAllLines(@filename);
        }
    }
}
