using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Grade1 { get; private set; }
        public int Grade2 { get; private set; }
        public double Average
        {
            get
            {
                return (Grade1 + Grade2) / 2.0;
            }
        }
        public Student(string firstName, string lastName, int grade1, int grade2)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade1 = grade1;
            Grade2 = grade2;;
        }
        public override string ToString() => 
            $"{FirstName,-15} {LastName,-15} {Grade1,5} {Grade2,5} {Average.ToString("F2"),6}";
    
    }
}
