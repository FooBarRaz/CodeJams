namespace TestCaseReader
{
    public class FileWriter
    {
        public static void WriteAllLines(string filename, string[] lines)
        {
            System.IO.File.WriteAllLines(@filename, lines);
        }
    }
}
