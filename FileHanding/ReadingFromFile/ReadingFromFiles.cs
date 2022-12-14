using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFromFile
{
    internal class ReadingFromFiles
    {
        static void Main(string[] args)
        {
            string folderPathForReading = "C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\2 - C# Examples\\LINQ Practice\\File Handling\\Files folder";
            string fileNameForReading = "Reading.txt";
            string filePathForReading = Path.Combine(folderPathForReading, fileNameForReading);

            StreamReader sr = new StreamReader(filePathForReading);

            Console.WriteLine("Content of the File");

            string readingText = sr.ReadLine();
            int numberOfLineInTheFile = 0;

            while (readingText != null)
            {
                numberOfLineInTheFile++;
                Console.WriteLine(readingText);
                readingText = sr.ReadLine();
            }

            Console.WriteLine("The number of lines in the file is " + numberOfLineInTheFile);

            Console.ReadLine();

            sr.Close();
        }
    }
}
