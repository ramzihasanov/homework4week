using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Group
    {
        
        private int _studentLimit;
        private string _no;

        public string No
        {
            get { return _no; }
            set
            {
                if (GropeNo(value))
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("qrup nomresi yanlis  formatda daxil edilib ");
                }
            }
        }


        private bool GropeNo(string groupNo)
        {
            if (groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    return true;
                }
            }
            return false;
        }


        public Student[] Students = Array.Empty<Student>();


        public Group(string no, int studentLimit)
        {
            this.No = no;
            this._studentLimit = studentLimit;
        }

        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value > 0 && value <= 20)
                {
                    _studentLimit = value;
                }
            }
        }



        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            if (Students.Length <= _studentLimit)
            {
                Students[^1] =student;

            }
            else Console.WriteLine("limit asilmisdir");
        }
    
           
    }
}

