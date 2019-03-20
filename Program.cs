using System;
using System.Collections.Generic;
using System.Linq;

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
            arrays.language = "JavaScript";
            comments.language = "JavaScript";


            // Create 3, or more, cohorts.
            Cohort c28 = new Cohort();
            Cohort c29 = new Cohort();
            Cohort c30 = new Cohort();
            Cohort c31 = new Cohort();

            c28.name = "c28";
            c29.name = "c29";
            c30.name = "c30";
            c31.name = "c31";


            // Create 4, or more, students and assign them to one of the cohorts.
            Student elyse = new Student();
            Student cole = new Student();
            Student austin = new Student();
            Student jordan = new Student();
            Student brian = new Student();
            Student abbey = new Student();

            elyse.firstname = "Elyse";
            elyse.lastname = "?";
            elyse.slackhandle = "@heyelyse";
            elyse.cohort = "c28";
            elyse.Exercises = new List<Exercise>();

            cole.firstname = "Cole";
            cole.lastname = "Slaw";
            cole.slackhandle = "@theColeSlaw";
            cole.cohort = "c29";
            cole.Exercises = new List<Exercise>();

            austin.firstname = "Austin";
            austin.lastname = "Bladez";
            austin.slackhandle = "@BladezOfMaury";
            austin.cohort = "c29";
            austin.Exercises = new List<Exercise>();

            jordan.firstname = "Jordan";
            jordan.lastname = "Rosas";
            jordan.slackhandle = "@RosasArePink";
            jordan.cohort = "c29";
            jordan.Exercises = new List<Exercise>();

            brian.firstname = "Brian";
            brian.lastname = "HannahsHubby";
            brian.slackhandle = "@hannahIsTheBestOMG";
            brian.cohort = "c30";
            brian.Exercises = new List<Exercise>();

            abbey.firstname = "Abbey";
            abbey.lastname = "Brown";
            abbey.slackhandle = "abbeybrown";
            abbey.cohort = "c31";
            abbey.Exercises = new List<Exercise>();


            c28.Students = new List<Student>();
            c29.Students = new List<Student>();
            c30.Students = new List<Student>();
            c31.Students = new List<Student>();

            c28.Students.Add(elyse);
            c29.Students.Add(cole);
            c29.Students.Add(austin);
            c29.Students.Add(jordan);
            c30.Students.Add(brian);
            c31.Students.Add(abbey);


            // Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor andy = new Instructor();
            Instructor joe = new Instructor();
            Instructor steve = new Instructor();
            Instructor jisie = new Instructor();

            andy.firstname = "Andy";
            andy.lastname = "Collins";
            andy.cohort = "c29";
            andy.slackhandle = "@hAndyDandy";

            joe.firstname = "Joe";
            joe.lastname = "Idk";
            joe.cohort = "c28";
            joe.slackhandle = "@cuppa";

            steve.firstname = "Steve";
            steve.lastname = "Brownlee??";
            steve.cohort = "c30";
            steve.slackhandle = "@coach";

            jisie.firstname = "Jisie";
            jisie.lastname = "David";
            jisie.cohort = "c30";
            jisie.slackhandle = "@coach";


            c28.Instructors = new List<Instructor>();
            c29.Instructors = new List<Instructor>();
            c30.Instructors = new List<Instructor>();
            c31.Instructors = new List<Instructor>();

            c28.Instructors.Add(joe);
            c29.Instructors.Add(andy);
            c30.Instructors.Add(steve);
            c31.Instructors.Add(jisie);

            // Have each instructor assign 2 exercises to each of the students.

            andy.AssignExercise(c29, functions);
            andy.AssignExercise(c29, arrays);
            joe.AssignExercise(c28, methods);
            joe.AssignExercise(c28, arrays);
            joe.AssignExercise(c28, comments);
            steve.AssignExercise(c30, comments);
            steve.AssignExercise(c30, functions);

            List<Cohort> Cohorts = new List<Cohort>();

            Cohorts.Add(c28);
            Cohorts.Add(c29);
            Cohorts.Add(c30);
            Cohorts.Add(c31);

            List<Student> students = new List<Student>();
            List<Exercise> exercises = new List<Exercise>();
            List<Instructor> instructors = new List<Instructor>();

            foreach(Cohort cohort in Cohorts) {

                foreach(Student student in cohort.Students){
                    students.Add(student);

                    if(student.Exercises != null){
                        foreach(Exercise exercise in student.Exercises){
                            exercises.Add(exercise);
                            Console.WriteLine($"{student.firstname} is working on {exercise.name}");
                        }
                    }
                }

                foreach(Instructor instructor in cohort.Instructors){
                    instructors.Add(instructor);
                }
            }

            Console.WriteLine();
            Console.WriteLine("---JavaScript Exercises---");

            IEnumerable<Exercise> JSExercises = exercises.Where(e => e.language == "JavaScript");

            foreach(Exercise exercise in JSExercises){
                Console.WriteLine($"{exercise.name}");
            }

            Console.WriteLine();
            Console.WriteLine("---Students C29---");

            IEnumerable<Student> StudentsC29 = students.Where(s => s.cohort == "c29");

            foreach(Student student in StudentsC29){
                Console.WriteLine($"{student.firstname} {student.lastname}");
            }

            Console.WriteLine();
            Console.WriteLine("---Instructors C29---");

            IEnumerable<Instructor> InstructorsC29 = instructors.Where(i => i.cohort == "c29");

            foreach(Instructor instructor in InstructorsC29){
                Console.WriteLine($"{instructor.firstname} {instructor.lastname}");
            }

            Console.WriteLine();
            Console.WriteLine("---Student List Alphabetical---");

            IEnumerable<Student> StudentsAlphabetical = students.OrderBy(s => s.lastname);

            foreach(Student student in StudentsAlphabetical){
                Console.WriteLine($"{student.firstname} {student.lastname}");
            }

            IEnumerable<Student> StudentsWithoutExercises = students.Where(s => s.Exercises.Count == 0);


            Console.WriteLine();
            Console.WriteLine("---Students Without Exercises---");
            foreach(Student student in StudentsWithoutExercises){
                Console.WriteLine($"{student.firstname} {student.lastname}");
            }

            IEnumerable<Student> StudentExerciseCount = students.OrderByDescending(s => s.Exercises.Count);

            Console.WriteLine();
            Console.WriteLine("---Student with Most Exercises---");

            Student StudentWithMostExercises = StudentExerciseCount.First();
            Console.WriteLine($"{StudentWithMostExercises.firstname} {StudentWithMostExercises.lastname}");


            Console.WriteLine();
            Console.WriteLine("---Cohort Student Totals---");
            foreach(Cohort cohort in Cohorts){
                CohortCount ThisCohort = new CohortCount(cohort);
                Console.WriteLine($"{cohort.name} has {ThisCohort.studentTotal} students");
            }

        }
    }
}
