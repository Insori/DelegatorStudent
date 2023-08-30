using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class Students
    {
        private List<Student> listOfStudent = new List<Student>();
        public delegate void PrintProcess(Student s);

        public void Add(Student s)
        {
            listOfStudent.Add(s);
        }

        public void Print(PrintProcess process)
        {
            foreach (Student s in listOfStudent)
            {
                process(s);
            }
        }

        public void Print()
        {
            Print((s) => Console.WriteLine(s));
        }
    }
}
