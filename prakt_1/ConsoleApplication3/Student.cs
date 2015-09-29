using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Student : Person, IDateAndCopy
    {
        private Education Educ;
        private int GroupN;
        ArrayList TestList = new ArrayList();
        private Exam[] Exams;
        public DateTime Date
        {
            get;
            set;
        }
        public Student(string namE, string surnamE, DateTime datE,  Education e, int gn, int excount) :base(namE,surnamE,datE)
        {
            this.Educ = e;
            this.GroupN = gn;
            TestList = new ArrayList();
            Exams = new Exam[excount];
        }
        public Student()
            : base()
        {
            Educ = Education.Bachelor;
            GroupN = 0;
            TestList = new ArrayList();
            Exams = new Exam[10];
        }
        public Person person
        {
            get
            {
                return new Person(this.name, this.surname, this.date);
            }
            set
            {
                this.name = value.name;
                this.surname = value.surname;
                this.date = value.date;
            }
        }
        public ArrayList testList
        {
            get
            {
                return TestList;
            }
            set
            {
                TestList = value;
            }
        }
        public Exam[] exams
        {
            get
            {
                return Exams;
            }
            set
            {
                Exams = value;
            }
        }
        public void AddExams(params Exam[] xx)
        {
            exams = xx;
        }
        public double SredBall
        {
            get
            {
                if (Exams[0] != null)
                {
                    int mark = 0;
                    int schet = 0;
                    foreach (Exam E in Exams)
                    {
                        if (E != null)
                            mark += E.Mark;
                        schet++;
                    }
                    return (mark / schet);
                }
                return 0;
            }
        }
        public void AddTests(params Test[] t)
        {
            testList = new ArrayList();
            foreach (Test b in t)
                testList.Add(b);
        }
        public override string ToString()
        {
            string exams = "";
            int l = 0;
            while (Exams.Length > l)
            {
                exams += "\n" + Exams[l].ToString();
                l++;
            }
            string tests = "";
            if (TestList.Count != 0)
                foreach (Test t in TestList)
                    tests += "\n" + t.ToString();
            return "Имя: " + name + "Фамилия: " + this.surname + "  " + this.date.ToString() + "Образование: " + Educ.ToString() + " Номер группы: " + GroupN + " Средний балл: " + SredBall.ToString() + " Экзамены: " + exams + " Зачеты " + tests;
        }
        public override string ToShortString()
        {
            return "Имя: " + name + "Фамилия: " + this.surname + "  " + this.date.ToString() + "Образование: " + Educ.ToString() + " Номер группы: " + GroupN + " Средний балл: " + SredBall.ToString();
        }
        new public object DeepCopy()
        {
            Student stud = new Student();
            stud.name = this.name;
            stud.surname = this.surname;
            stud.date = this.date;
            stud.GroupN = this.GroupN;
            stud.Educ = this.Educ;
            stud.Exams = this.Exams;
            stud.TestList = this.TestList;
            return stud;
        }
        public object DeepCopy(int groupN, Education Ed)
        {
            Student stud = new Student();
            stud.name = this.name;
            stud.surname = this.surname;
            stud.date = this.date;
            stud.GroupN = groupN;
            stud.Educ = Ed;
            stud.Exams = this.Exams;
            stud.TestList = this.TestList;
            return stud;
        }
        public int groupNum
        {
            get
            {
                return GroupN;
            }
            set
            {
                string msg = "Номер группы должен быть не менньше 100 и не больше 599!";
                try
                {
                    if (value <= 100 || value >= 599)
                        throw new FormatException(msg);
                    GroupN = value;

                }
                catch (FormatException)
                {
                    Console.WriteLine(msg);
                }
            }
        }

    }
}
