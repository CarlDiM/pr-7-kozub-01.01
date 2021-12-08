using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7_kozub_01._01
{
    internal class Student : Man
    {
        private string _faculty;
        private int _course;
        private string _group;

        public string Faculty { get { return _faculty; } set { _faculty = value; } }
        public int Course
        {
            get { return _course; }
            set
            {
                if (value > 0)
                    _course = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public string Group { get { return _group; } set { _group = value; } }

        public Student()
        {
            Faculty = null;
            Course = 1;
            Group = null;
        }

        public Student(string name, char sex, int age, int weight, string faculty, int course, string group) : base (name, sex, age, weight)
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        public static Student operator ++(Student student)
        {
            student.Course++;
            return student;
        }
    }
}
