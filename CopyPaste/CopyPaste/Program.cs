using System.Security.Cryptography.X509Certificates;

namespace CopyPaste
{
    internal class Program
    {
        static void CopyFile()
        {
            Console.WriteLine("Please enter the path to dir wich conteins a file.");

            //C:\Users\zsirc\OneDrive\Documents\GitHub\DotNetTaskLearning\TestFolder
            string sourcePath = Console.ReadLine();

            string[] filePaths = Directory.GetFiles(sourcePath);
            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine($"File number {i + 1} - {System.IO.Path.GetFileName(path)}");
            }

            Console.WriteLine("What file do yo want to copy?");

            //string fileName = "test.txt";
            string fileName = Console.ReadLine();

                               

            Console.WriteLine("Where do you want to copy the file? Please write the path.");

            //string targetPath =   C:\Users\zsirc\OneDrive\Documents\GitHub\DotNetTaskLearning\TestFolder\SubDir
            string destinationPath = Console.ReadLine();


            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(destinationPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory already exists, this method does not create a new directory.
            //System.IO.Directory.CreateDirectory(destinationPath);

            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****File manager*****");

            try
            {
                CopyFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                CopyFile();
            }

            Console.WriteLine("Your file was succesfully copied");
        }
    }
}