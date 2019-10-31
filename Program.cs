using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor();
            p.Faculty = "Economics";
            p.Name = "Mircea Radu";
            p.Specialisation = "Trade, Travel and Services";

            Student s = new Student();
            s.Faculty = "Economics";
            s.Name = "Anda Gheorge";
            s.Year = 3;

            Course c = new Course();
            c.StudentList = new List<Student>();
            c.StudentList.Add(s);
            c.Professor = p;
            c.Year = 3;
            c.Name = "Marketing";
            c.Print();

        }
    }
}
