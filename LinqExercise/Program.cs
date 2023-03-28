using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 3, 2, 1, 4, 9, 6, 7, 8, 5, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            var summation = numbers.Sum(x => x);
            Console.WriteLine(summation);
            Console.WriteLine("");

            //TODO: Print the Average of numbers

            var average = numbers.Average(x => x);
            Console.WriteLine(average);
            Console.WriteLine("");

            //TODO: Order numbers in ascending order and print to the console

            var ascend = numbers.OrderBy(x => x);
            foreach (var num in ascend)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");


            //TODO: Order numbers in decsending order and print to the console

            var descend = numbers.OrderByDescending(x => x);
            foreach (var num in descend)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");

            //TODO: Print to the console only the numbers greater than 6

            var greater6 = numbers.Where(x => x > 6).OrderByDescending(x => x);
            foreach (var num in greater6)
            { 
                Console.WriteLine(num); 
            }
            Console.WriteLine("");
            
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            var only4 = numbers.Where(x => x > 5).OrderBy(x => x);
            foreach (var num in only4)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 28;
            descend = numbers.OrderByDescending(x => x);
            foreach (var num in descend)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");



            // List of employees ****Do not remove this****

            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var csFilter = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            foreach (var employee in csFilter)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine("");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var ageName = employees.Where(person => person.Age > 26).OrderBy(person => person.Age > 26).ThenBy( person => person.FirstName);
            foreach (var employee in ageName) 
            {
                Console.WriteLine($"{employee.FullName}, {employee.Age}");
            }
            Console.WriteLine("");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var filterEmployee = employees.Where(person => person.YearsOfExperience <= 10 && person.Age > 35);
            var sum1 = filterEmployee.Sum(person => person.YearsOfExperience);
            var avg1 = filterEmployee.Average(person => person.YearsOfExperience);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine("");

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee ("James", "Hunt", 3, 56)).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}, {employee.Age}, {employee.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
