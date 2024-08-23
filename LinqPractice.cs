using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cSharpTutorials
{
    public class LinqPractice
    {
        public void DoSomeLinqPractice()
        {
            //Given a list of integers, write a LINQ query to find all even numbers.
            var ints = Enumerable.Range(1, 100);
            //go through list
            //check each value divides by 2
            //save each value to a list
            var evens = ints.Where(x => x % 2 == 0);
            evens.ToList().ForEach(x => { Console.WriteLine(x); });

//Create a list of strings and use LINQ to find all strings that start with the letter 'A'.
//Given a list of people(with properties Name and Age), find the average age of all people over 18.
//Create two lists of integers.Write a LINQ query to find all numbers that appear in both lists.
//Given a list of words, use LINQ to find the longest word.
//Create a list of integers and use LINQ to square each number and return a new list.
//Given a list of strings, write a LINQ query to count how many times each string appears in the list.
//Create a list of products(with properties Name, Price, and Category).Use LINQ to find the most expensive product in each category.
//Given a string, use LINQ to count the number of vowels in it.
//Create a list of dates.Use LINQ to find all dates that fall on a weekend.
//Given a list of integers, use LINQ to find the second largest number.
//Create a list of students(with properties Name and Grades, where Grades is a list of integers).Use LINQ to find all students with an average grade above 80.
        }
    }
}
