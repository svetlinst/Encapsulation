using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public int Age => this.age;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        //public override string ToString()
        //{
        //    return $"{firstName} {lastName} is {age} years old.";
        //}

        public override string ToString()
        {
            return $"{firstName} {lastName} receives {salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age<30)
            {
                salary += salary * percentage / 200;
            }
            else
            {
                salary += salary * percentage / 100;

            }
        }
    }
}
