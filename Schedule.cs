using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog122_S24_L8_MidtermReview
{
    public class Schedule
    {
        // Fields
        string _studentId;
        string _studentName;
        List<Course> _courses;
 
        // Constructor
        public Schedule()
        {
            Random rand = new Random();
            _studentId = rand.Next(10000000, 100000000).ToString();
            _courses = new List<Course>();
        }

        // Properties
        public string StudentId { get => _studentId;  }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public List<Course> Courses { get => _courses;  }

        // Methods

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        // Student ID
        // Student Name
        //
        // Classes

        public string FormatSchedule()
        {
            // Methods
            string formattedString = "";
            // Student ID
            formattedString += $"Student Id: {_studentId}\n";
            // Student Name
            formattedString += $"Student Name: {_studentName}\n";

            //
            // Courses
            foreach (Course course in _courses)
            {
                formattedString += course.ToString() + "\n";
            }

            return formattedString;
        }

        public override string ToString()
        {
            return $"{_studentId} - {_studentName}";
        }

    }
}
