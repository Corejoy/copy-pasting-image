

namespace MainPoint
{
    // Class to store global variables
    class Global
    {
        public static string sourceFile = Console.ReadLine();
        public static string destinationFile = Console.ReadLine();
        public static string sourcefile = sourceFile;
        public static string destination = destinationFile;
        public static string result;
        
    }
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Source file full path");
            Console.WriteLine("Destination file full path");
            Copy();
        }

        public static void Copy() // Method for copying and pasting the file infinitely
        {
            File.Copy(Global.sourceFile, Global.destinationFile, true); // true allows overwriting
            for (long i = 0; i < 10000000000000; i++)
            {
                Global.result = Global.destination + i + ".png";
                File.Copy(Global.sourcefile, Global.result);
            }


        }
    }
}
