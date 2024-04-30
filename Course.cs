using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L8_MidtermReview
{
    public class Course
    {
        string _name;
        string _location;

        public Course(string name, string location)
        {
            _name = name;
            _location = location;
        }

        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }


        // Fields
        // Constructor

        // Properties

        // Methods
        public override string ToString()
        {
            return $"{_name} - {_location}";
        }
    }
}
