using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySimpleMvcProject.Models
{
    public class Student
    {
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public DateTime RegisterDate
        {
            get;
            set;
        }
    }
}