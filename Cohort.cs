using System;
using System.Collections.Generic;

namespace NSS {
    public class Cohort {
        public string name { get; }

        public List<Instructor> Instructors { get; set; }
        public List<Student> Students { get; set; }
    }
}