using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Student
    {
        private int ID;
        private string Name;
        private int Age;

        public Student() { }
        public Student(int iD, string name, int age)
        {
            ID1 = iD;
            Name1 = name;
            Age1 = age;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

        public void XuatThongTin()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-5}", ID1, Name1, Age1);
        }
    }
}
