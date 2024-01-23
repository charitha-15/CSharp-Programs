using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class FilesEx
    {
        public void fileMethod()
        {
            /*// Craete file way 1
            string text = "Hello, This is the last concept in basics of C#!";
            File.WriteAllText("C:/Users/cchevuri/Documents/newfile.txt", text);

            string readText = File.ReadAllText("C:/Users/cchevuri/Documents/newfile.txt");
            Console.WriteLine("The content is:"+readText);*/

            /*// Delete file
            string FilePath = "C:/Users/cchevuri/Documents/newfile.txt";
            File.Delete(FilePath);
            Console.WriteLine($"File deleted check the path: " + FilePath);*/


            /*// Create file way2
            string filePath = "C://Users//cchevuri//Documents//way2file.txt";
           // File.Create(filePath); 
            string fileData = "This is data in file";
            File.WriteAllText("C:/Users/cchevuri/Documents/way2file.txt", fileData);
            Console.WriteLine("The path of created files is: " + filePath);
            string readData = File.ReadAllText("C:/Users/cchevuri/Documents/way2file.txt");
            Console.WriteLine("The content is:" + readData);*/

            // Append data into the file
            string appendData = "Now, I am appending the data";
            //File.AppendText("C:/Users/cchevuri/Documents/way2file.txt", appendData);
            string readData = File.ReadAllText("C:/Users/cchevuri/Documents/way2file.txt");
            Console.WriteLine("The content is:" + readData); 
        }
    }
}
