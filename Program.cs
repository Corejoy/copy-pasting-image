namespace Program {

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
            Console.WriteLine("[+] First get the FULL PATH of the source image (C://something//image.png)");
            Console.WriteLine("[+] Now write the FULL PATH of where do you want to paste the image");
            Console.WriteLine("[!] An image with the same name and extension must be in the destination folder");
            Console.WriteLine("[*] Example: C://Capibara.png");
            Console.WriteLine("[*] C://user//Capibara.png");
            Console.WriteLine("If you done it well, the image will starting being pasted");
            Console.WriteLine("Now write the source of the image and after the destination");
            Copy();
        }

        public static void Copy() // Method for copying and pasting the file infinitely
        {
            File.Copy(Global.sourceFile, Global.destinationFile, true); // true allows overwriting
            for (long i = 0; i < 1000000000000000000; i++)
            {
                Global.result = Global.destination + i + ".png";
                File.Copy(Global.sourcefile, Global.result);
            }

        }
    }
}