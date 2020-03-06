using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileHandleDemo
{
    class FileOperation
    {
        public void CreateFile() 
        { 
            string path = @"C:\Users\Admin\Desktop\demo.txt"; 
            if (!File.Exists(path)) 
            { using (StreamWriter sw = File.CreateText(path)) 
                { 
                    sw.WriteLine("My name is Vishnu"); 
                    sw.WriteLine("I am from Guntur"); 
                    sw.WriteLine("Now Ia am staying at Sholinganallur"); 
                    sw.Flush(); 
                } 
            } 
        }
        public void DisplayFile() 
        { 
            string path = @"C:\Users\Admin\Desktop\demo.txt"; 
            using (StreamReader sr = File.OpenText(path)) 
            { 
                string s;
                s = File.ReadAllText(path);
                Console.WriteLine(s);
            }
        }
        public void AddToFile() 
        { string path = @"C:\Users\Admin\Desktop\demo.txt"; 
            using (StreamWriter sw = File.AppendText(path)) 
            { 
                sw.WriteLine("lalalalalalalalallalalalallalala"); 
                sw.WriteLine(""); 
                sw.WriteLine("No more arguments"); 
                sw.Flush(); 
            } 
        }
        public void DeleteFile() 
        { 
            string path = @"C:\Users\Admin\Desktop\demo.txt"; 
            File.Delete(path); 
            Console.WriteLine("File Deleted Successfully..."); 
        }
    }
}
