using System;
using System.Collections.Generic;

namespace NSS {
public class Student {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string slackhandle { get; set; }

        public List<Exercise> Exercises { get; set; }
    }
}