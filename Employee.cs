using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingReview
{
    [CodeReview("Daneil", "03/08/2023", true)]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public Employee(string firstName, string lastName, double baseSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = baseSalary;
            Bonus = 0;
        }

        [CodeReview("Daneil", "03/08/2023", true)]
        public double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public void ApplyBonus(double bonusAmount)
        {
            if (bonusAmount < 0)
            {
                throw new ArgumentException("Bonus amount cannot be negative.");
            }
            Bonus += bonusAmount;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Salary: {CalculateSalary()}";
        }
    }
}
