using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHanding
{
    internal class WritingToFile
    {
        public static void Main(string[] args)
        {
            string folderPath = "C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\2 - C# Examples\\LINQ Practice\\File Handling\\Files folder";
            string fileName = "Writing.txt";

            string filePath = Path.Combine(folderPath, fileName);

            StreamWriter sw = new StreamWriter(filePath);

            Console.WriteLine("Enter the Text that you want to write on the file - ");

            string userText = Console.ReadLine();

            sw.WriteLine(userText);

            sw.Flush();

            sw.Close();

            Console.ReadLine();
        }
    }
}
