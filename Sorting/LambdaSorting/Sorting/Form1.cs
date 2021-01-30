using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();

            // Initialiate the Model

            students = new List<Student>();

            students.Add(new Student("Joe", "Smith", 75, 87 ));
            students.Add(new Student("Joanne", "Smith",  75, 88 ));
            students.Add(new Student("Harsh", "Patel",  55, 91 ));
            students.Add(new Student("Mitel", "Patel",  82, 66 ));
            students.Add(new Student("Ishwar", "Singh", 91, 93 ));
            students.Add(new Student("Amy", "Nguyen",  91, 65 ));

            populateList();
        }

        private void SortGrade1Button_Click(object sender, EventArgs e)
        {
            students.Sort((s2, s1) =>
            {
                if (s2.Grade1 > s1.Grade1)
                    return -1;
                else if (s2.Grade1 < s1.Grade1)
                    return 1;
                return 0;
            });
            populateList();
        }

        private void SortGrade2Button_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s2.Grade2 - s1.Grade2);
            populateList();
        }

        private void SortAverageButton_Click(object sender, EventArgs e)
        {
            // Delcare a function to match the exprected delegate 

            Comparison<Student> AverageCompare = (s1, s2) => (s2.Average - s1.Average) > 0 ? 1
                                      : (s1.Average - s2.Average) > 0 ? -1 : 0;

            students.Sort((s1, s2) => (s2.Average - s1.Average) > 0 ? 1
                                      : (s1.Average - s2.Average) > 0 ? -1 : 0);

            // or 
            students.Sort(AverageCompare);

            populateList();
        }

        // Populate Form Data

        private void populateList()
        {
            StudentListBox.Items.Clear();
            foreach (Student s in students)
                StudentListBox.Items.Add(s);
        }

        private void SortNameButton_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.LastName.CompareTo(s2.LastName));
            populateList();
        }

        private void Grade1Then2Button_Click(object sender, EventArgs e)
        {
            students.Sort((s2, s1) =>
            {
                // Grade 1 is the primary sort
                if (s2.Grade1 > s1.Grade1)
                    return -1;
                else if (s2.Grade1 < s1.Grade1)
                    return 1;
                else
                {   
                    // Grade 2 is the secondary sort when grade1 is the same
                    if (s2.Grade2 > s1.Grade2)
                        return -1;
                    else if (s2.Grade2 > s2.Grade2)
                        return 1;
                }
                return 0;
            });
            populateList();
        }
    }
}
