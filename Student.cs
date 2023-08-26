using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingReview
{
    //[CodeReview("Daneil", "04/08/2023", true)]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentId { get; private set; }
        public List<double> Grades { get; private set; }

        private static int nextStudentId = 1000;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            StudentId = GenerateStudentId();
            Grades = new List<double>();
        }

        private string GenerateStudentId()
        {
            return $"S{nextStudentId++}";
        }

        [CodeReview("Daneil", "04/08/2023", false)]
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }
        }

        [CodeReview("Daneil", "04/08/2023", false)]
        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            return Grades.Average();
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}, Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}, Average Grade: {CalculateAverageGrade():F2}";
        }
    }
}
