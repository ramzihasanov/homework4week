using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public  string FullName { get; set; }
        public string GroupNo { get; set; }
        public int AvgPoint { get; set; }
        public Student(string fullName)
        {
            FullName = fullName;
           
        }
    }
}
