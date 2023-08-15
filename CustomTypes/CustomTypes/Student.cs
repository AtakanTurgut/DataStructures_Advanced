using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Student : IComparable
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public double GPA { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string nameSurname, double gPA)
        {
            Id = id;
            NameSurname = nameSurname;
            GPA = gPA;
        }

        public override string ToString()
        {
            return $"{Id,-5} {NameSurname,-20} {GPA,-10}";
        }

        public int CompareTo(object? obj)
        {
            var other = (Student)obj;
            /*
            if (this.GPA < other.GPA)
            {
                return -1 ;
            }
            else if (this.GPA == other.GPA)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            */

            //return string.Compare(this.NameSurname, other.NameSurname);

            return this.Id.CompareTo(other.Id);
        }
    }
}
