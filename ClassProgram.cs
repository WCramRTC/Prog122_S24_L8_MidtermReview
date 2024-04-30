using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L8_MidtermReview
{
    public class ClassProgram
    {
        // Fields
        List<Course> _programmingCourses;
        List<Course> _databaseCourses;
        List<Course> _frontEndCourses;

        public ClassProgram()
        {
            _programmingCourses = new List<Course>();
            _programmingCourses.Add(new Course("Programming 122", "J310"));

            _databaseCourses = new List<Course>();
            _databaseCourses.Add(new Course("Database 1", "J315"));


            _frontEndCourses = new List<Course>();
            _frontEndCourses.Add(new Course("Front End Web Development", "J312"));

        }

        public List<Course> ProgrammingCourses { get => _programmingCourses;}
        public List<Course> DatabaseCourses { get => _databaseCourses; }
        public List<Course> FrontEndCourses { get => _frontEndCourses; }
    } // class

} // namespace
