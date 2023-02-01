using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
       public enum GradeLevels { FreshMan, Sophomore, Junior, Student }
        public GradeLevels gradelevel { get; set; }

    }
}
