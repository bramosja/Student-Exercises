using System;
using System.Collections.Generic;

namespace NSS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.

            Exercise functions = new Exercise();
            Exercise methods = new Exercise();
            Exercise arrays = new Exercise();
            Exercise comments = new Exercise();

            functions.name = "functions";
            methods.name = "methods";
            arrays.name = "arrays";
            comments.name = "comments";

            functions.language = "C#";
            methods.language = "C#";
            arrays.language = "C#";
            comments.language = "C#";


            // Create 3, or more, cohorts.
            Cohort c28 = new Cohort();
            Cohort c29 = new Cohort();
            Cohort c30 = new Cohort();

            // Create 4, or more, students and assign them to one of the cohorts.
            Student elyse = new Student();
            Student cole = new Student();
            Student austin = new Student();
            Student jordan = new Student();
            Student brian = new Student();

            elyse.firstname = "Elyse";
            elyse.lastname = "?";
            elyse.slackhandle = "@heyelyse";
            elyse.Exercises = new List<Exercise>();

            cole.firstname = "Cole";
            cole.lastname = "Slaw";
            cole.slackhandle = "@theColeSlaw";
            cole.Exercises = new List<Exercise>();

            austin.firstname = "Austin";
            austin.lastname = "Bladez";
            austin.slackhandle = "@BladezOfMaury";
            austin.Exercises = new List<Exercise>();

            jordan.firstname = "Jordan";
            jordan.lastname = "Rosas";
            jordan.slackhandle = "@RosasArePink";
            jordan.Exercises = new List<Exercise>();

            brian.firstname = "Brian";
            brian.lastname = "HannahsHubby";
            brian.slackhandle = "@hannahIsTheBestOMG";
            brian.Exercises = new List<Exercise>();


            c28.Students = new List<Student>();
            c29.Students = new List<Student>();
            c30.Students = new List<Student>();

            c28.Students.Add(elyse);
            c29.Students.Add(cole);
            c29.Students.Add(austin);
            c29.Students.Add(jordan);
            c30.Students.Add(brian);


            // Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor andy = new Instructor();
            Instructor joe = new Instructor();
            Instructor steve = new Instructor();

            andy.firstname = "Andy";
            andy.lastname = "Collins";
            andy.slackhandle = "@hAndyDandy";

            joe.firstname = "Joe";
            joe.lastname = "Idk";
            joe.slackhandle = "@cuppa";

            steve.firstname = "Steve";
            steve.lastname = "Brownlee??";
            steve.slackhandle = "@coach";


            c28.Instructors = new List<Instructor>();
            c29.Instructors = new List<Instructor>();
            c30.Instructors = new List<Instructor>();

            c28.Instructors.Add(joe);
            c29.Instructors.Add(andy);
            c30.Instructors.Add(steve);

            // Have each instructor assign 2 exercises to each of the students.

            andy.AssignExercise(c29, functions);
            andy.AssignExercise(c29, arrays);
            joe.AssignExercise(c28, methods);
            joe.AssignExercise(c28, arrays);
            steve.AssignExercise(c30, comments);
            steve.AssignExercise(c30, functions);

            List<Cohort> Cohorts = new List<Cohort>();

            Cohorts.Add(c28);
            Cohorts.Add(c29);
            Cohorts.Add(c30);

            List<Student> AllStudents = new List<Student>();

            foreach(Cohort cohort in Cohorts) {

                List<Student> students = new List<Student>();

                foreach(Student student in cohort.Students){
                    students.Add(student);

                    List<Exercise> exercises = new List<Exercise>();

                    foreach(Exercise exercise in student.Exercises){
                        exercises.Add(exercise);
                        Console.WriteLine($"{student.firstname} is working on {exercise.name}");
                    }
                }
            }

        }
    }
}
