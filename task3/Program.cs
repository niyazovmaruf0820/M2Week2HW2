using System.Data.SqlTypes;
using task3;

Student student = new Student();
student.Name = "Maruf Niyazov";
student.GradeLevel = 9;
student.TestScores = new int[]{90, 100, 100};
System.Console.WriteLine(student.GetInfo());