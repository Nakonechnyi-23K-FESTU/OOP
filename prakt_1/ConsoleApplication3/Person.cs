using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }

    enum Education
    {
        Specialist, Bachelor, SecondEducation
    }

    class Person
    {
        private string Name;
        private string SurName;
        private DateTime Date;
        public Person(string name, string surname, DateTime date)
        {
            this.Name = name;
            this.SurName = surname;
            this.Date = date;
        }
        public Person()
        {
            this.Name = "Имя";
            this.SurName = "Фамилия";
            this.Date = DateTime.Today;
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value ;
            }
        }
        public string surname
        {
            get
            {
                return SurName;
            }
            set
            {
                SurName = value;
            }
        }
        public DateTime date
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
        public int DateYear
        {
            get
            {
                return Date.Year;
            }
            set
            {
                this.Date = new DateTime(value, this.Date.Month, this.Date.Day);
            }
        }
        public override string ToString()
        {
            return "Имя: " + this.Name + " Фамилия: " + this.SurName + " Дата рождения: " + this.Date.ToString();
        }
        public virtual string ToShortString()
        {
            return Name + " " + SurName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Person p = obj as Person;
            if (p as Person == null)
                return false;
            return p.Name == this.Name && p.SurName == this.SurName && p.Date == this.Date;
        }
        public static bool operator ==(Person p, Person q)
        {
            return p.Equals(q);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !a.Equals(b);
        }
        public override int GetHashCode()
        {
            int hashcode;
            return hashcode = Name.GetHashCode() + SurName.GetHashCode() + Date.GetHashCode();
        }
        public Person DeepCopy()
        {
            Person P = new Person();
            P.Name = this.Name;
            P.SurName = this.SurName;
            P.Date = this.Date;
            return P;
        }
    }
}
