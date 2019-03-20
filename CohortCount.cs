using System;
using System.Collections.Generic;

namespace NSS {
    public class CohortCount {

        public string name {get;}
        public int studentTotal {get;}
        public CohortCount(Cohort cohort){
            name = cohort.name;
            studentTotal = cohort.Students.Count;
        }
    }
}