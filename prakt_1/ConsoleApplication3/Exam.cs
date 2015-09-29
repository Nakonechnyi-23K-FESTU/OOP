using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Exam : IDateAndCopy
    {
        public string Subject
        { get; set; }
        public int Mark
        { get; set; }
        public DateTime ExamDate
        { get; set; }
        public Exam(string subj, int mark, DateTime exdate)
        {
            Subject = subj;
            Mark = mark;
            ExamDate = exdate;
        }
        public Exam()
        {
            Subject = "SomeSubject";
            Mark = 2;
            ExamDate = DateTime.Now;
        }
        public override string ToString()
        {
            return "Предмет " + Subject + " Оценка " + Mark.ToString() + " Дата экзамена " + ExamDate.ToString();
        }
        public object DeepCopy()
        {
            Exam E = new Exam();
            E.ExamDate = this.ExamDate;
            E.Mark = this.Mark;
            E.Subject = this.Subject;
            return E;
        }
        public DateTime Date
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
    }
}
