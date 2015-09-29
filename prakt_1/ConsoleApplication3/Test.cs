using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Test : IDateAndCopy
    {
        public string Subject
        { get; set; }
        public bool TestOK
        { get; set; }
        public Test(string subj, bool isOk)
        {
            Subject = subj;
            TestOK = isOk;
        }
        public Test()
        {
            Subject = "SomeSubject";
            TestOK = true;
        }
        public override string ToString()
        {
            return "Предмет: " + Subject + "Зачет: " + TestOK.ToString();
        }
        public object DeepCopy()
        {
            Test T = new Test();
            T.Subject = this.Subject;
            T.TestOK = this.TestOK;
            return T;
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
