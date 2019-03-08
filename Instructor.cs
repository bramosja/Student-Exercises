using System;
using System.Collections.Generic;

namespace NSS {
    public class Instructor {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string slackhandle { get; set; }

        public void AssignExercise(Cohort cohort, Exercise exercise){
            foreach(Student student in cohort.Students){
                student.Exercises.Add(exercise);
            }
        }
    }
}