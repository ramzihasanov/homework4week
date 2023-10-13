using Core.Models;

namespace namespace1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AA206", 12);


            Student student1 = new Student("remzi hesenov");
            student1.GroupNo = "BB206"; 
            student1.AvgPoint = 100;


            group.AddStudent(student1);


            Student student2 = new Student("eli eliyev");
            student2.GroupNo = "BB206";
            student2.AvgPoint = 90;


            group.AddStudent(student2);


            Console.WriteLine("Sinifdeki telebeler :");
            foreach (var student in group.Students)
            {
                if (student != null)
                {
                    Console.WriteLine($"Adı Soyadı: {student.FullName} -  GrupNo: {student.GroupNo} - Ortalama: {student.AvgPoint}");
                }
                
            }
        }
    } 
   
}
