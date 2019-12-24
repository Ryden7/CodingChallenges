using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 1, 2, 5, 7, 9, 12, 15, 25, 50 };

            //var select = mylist.Select(n => n > 0 && n < 5);
            var select = mylist.Where(n => n > 0 && n < 5);


            foreach (var item in select)
            {
                Console.WriteLine(item);
            }

            Console.Read();

            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //var selectResult = studentList.Select(s => s.Age);

            //// iterate selectResult
            //foreach (var item in selectResult)
            //    Console.WriteLine(item);

            //Console.Read();
        }

        
    }
    

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
