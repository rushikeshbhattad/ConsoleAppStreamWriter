using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStreamWriter
{
    class StudentFileDemo
    {

        internal void EnterDetails(string StudentID, string StudentName, int studentMarks)
        {
            String data;
            FileStream fs = new FileStream(@"C:/Users/Admin/Desktop/stud.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            data = StudentID + "\t" + StudentName + "\t" + studentMarks;
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string studentID;
            string studentName;
            int studentMarks;
            int i = 0;
            string resp;
            do
            {
                i++;
                Console.Write("Enter Student {0} StudentID: ", i);
                studentID = Console.ReadLine();
                Console.Write("Enter Student {0} Name: ", i);
                studentName = Console.ReadLine();
                Console.Write("Enter Student {0} Marks: ", i);
                studentMarks = Convert.ToInt32(Console.ReadLine());
                StudentFileDemo sfo = new StudentFileDemo();
                sfo.EnterDetails(studentID, studentName, studentMarks);
                Console.WriteLine("Press Y to continue");
                resp = Console.ReadLine();
            } while (resp == "Y" || resp == "y");
        }
    }
}
