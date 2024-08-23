using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.model
{
    internal struct  Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name )
        {
            Name = name;   
        }
    }
}
