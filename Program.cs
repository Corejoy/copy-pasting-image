// TODO: Resort the name and change it every time, the code works very well by now

namespace ImageBot
{
    // Class to store global variables
    class Global
    {
        public static string sourceFile = @"C:\Users\glitc\Pictures\Pinterest\kj.jpg";
        public static string destinationFile = @"C:\Users\glitc\Pictures\reyna.png";
        public static string fileName = @"reyna.png"; // For resort the name of the file and change it
    }
    class Program 
    {
        public static void Main(string[] args)
        {
            Copy();
        }

        public static void Copy() // Method for copying and pasting the file infinitely
        {
            File.Copy(Global.sourceFile, Global.destinationFile, true); // true allows overwriting
            while (check() == true || check() == false)
            {
                Global.fileName = "reyna" + "1" + ".png";
            }
        }

        public static  Boolean check()
        {
            if (File.Exists(Global.fileName))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}