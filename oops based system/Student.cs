using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_based_system
{
    internal class Student
    {
        public string Name;
        public int Class;
        public char Section;

        public Student(string name, int @class, char section)
        {
            Name = name;
            Class = @class;
            Section = section;
        }
        //public  Student()
        //{
        //    Console.WriteLine("Enter Name of student");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Enter Class");
        //    int  Class = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter Section");
        //    char Section = char.Parse(Console.ReadLine());
        //}
        //public void Display()
        //{
        //    Console.Write("Name    :" + Name);
        //    Console.Write("class    :" +Class);
        //    Console.Write("Section    :" + Section);
        //}
    }
}
