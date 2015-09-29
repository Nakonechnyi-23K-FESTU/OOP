using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("Sashko", "Nakonechnyi", DateTime.Now, Education.Specialist, 23, 2);
            Console.WriteLine(Student1.ToShortString());
            Console.WriteLine();
            Student1.date = DateTime.Now;
            Student1.groupNum = 199;
            Student1.Date = DateTime.Now;
            Exam[] ex = new Exam[2];
            ex[0] = new Exam("Maths", 5, DateTime.Now);
            ex[1] = new Exam("English", 4, DateTime.Now);
            Student1.AddExams(ex);
            Console.WriteLine(Student1.ToString());
            Console.WriteLine();
            Person p1 = new Person("X", "T", DateTime.Now);
            Person p2 = new Person("X", "T", DateTime.Now);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine();
            Student Student2 = new Student("Ivan", "Ivanov", DateTime.Now, Education.Bachelor, 200, 2);
            Student2.AddExams(new Exam("Inforamatics", 3, DateTime.Now), new Exam(), new Exam("OOP",5,DateTime.Now));
            Student2.AddTests(new Test("Physics", true), new Test("Economics", false));
            Console.WriteLine(Student2.ToString());
            Console.WriteLine();
            Console.WriteLine(Student2.person.ToString());
            Console.WriteLine();
            Student Student3 = (Student) Student2.DeepCopy();
            Student2.name = "Sashko";
            Console.WriteLine(Student2.ToShortString());
            Console.WriteLine(Student3.ToShortString());
            Console.WriteLine();
            try
            {
                Student1.groupNum=99;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            foreach(Exam E in Student2.exams)
                Console.WriteLine(E.ToString()); 
            foreach (Test T in Student2.testList)
                Console.WriteLine(T.ToString());
            Console.WriteLine();
            foreach (Exam e in Student3.exams)
                if (e.Mark > 3)
                    Console.WriteLine(e.ToString());
        }
    }
}
