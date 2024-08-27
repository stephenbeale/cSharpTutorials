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
            Console.WriteLine("Given a list of integers, write a LINQ query to find all even numbers.");
            var ints = Enumerable.Range(1, 100);
            var evens = ints.Where(x => x % 2 == 0);
            evens.ToList().ForEach(x => { Console.Write(x + ", "); });

            Console.WriteLine("1.Create a list of strings and use LINQ to find all strings that start with the letter 'A'");
            var strs = new List<string> { "some", "strings", "in", "a", "short", "annoying", "list", "Aha!" };
            Console.WriteLine("\n\nStrings Beginning with 'a'\n");

            //Mine - BUT DOES NOT catch capitals! Does now that I've added it, but didn't before.
            var strsWithAStart = strs.Where(x => x.StartsWith("a", StringComparison.OrdinalIgnoreCase));
            strsWithAStart.ToList().ForEach(x => { Console.WriteLine(x); });

            //Perplexity shortened it to:
            strs.Where(x => x.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine("2. Given a list of people(with properties Name and Age), find the average age of all people over 18.");

            //Create people
            //Add people to list
            var people = new List<Person> {
            new Person("Johnny", 21),
            new Person("John", 100),
            new Person("Jo", 10),
            new Person("Josh", 70)
        };

            //Filter to over 18s AND calculate average age in one.
            var over18s = people
                .Where(x => x.Age >= 18)
                .Average(x => x.Age);
            Console.WriteLine($"Average age of over 18s in list: {over18s:F2}");

            //Create two lists of integers.Write a LINQ query to find all numbers that appear in both lists.
            var ints1 = Enumerable.Range(0, 100);
            var ints2 = Enumerable.Range(-100, 200);

            //Mine
            var inBoth = Enumerable.Intersect(ints1, ints2);
            Console.Write("\nIn both lists: ");
            inBoth.ToList().ForEach(x => Console.Write($"{x}, "));
            //Perplexity
            var inBothPerplexity = ints1.Intersect(ints2);
            Console.Write("\nIn both lists: ");
            inBothPerplexity.ToList().ForEach(x => Console.Write($"{x}, "));

            Console.WriteLine("Given a list of words, use LINQ to find the longest word.");
            var wordList = new List<string>
            {
                "Apple", "banana", "Orange", "Grapefruit", "watermelon", "Blueberry", "strawberry", "Pineapple", "blood-orange", "well-being", "Quick",
                "extraordinary", "chocolate-chip", "howl", "scorn", "Blueberry", "Pineapple"
            };

            var longestWordSort = wordList
                .OrderByDescending(x => x.Length)
                .First();
            Console.WriteLine($"\nLongest word is: {longestWordSort}");

            Console.WriteLine("Create a list of integers and use LINQ to square each number and return a new list.");
            var myInts = Enumerable.Range(0, 25);
            Console.WriteLine("\nRange of ints: ");
            myInts.ToList().ForEach(x => { Console.Write($"{x}, "); });
            Console.WriteLine("\nSquared ints: ");
            myInts.Select(x => x * x).ToList().ForEach(x => { Console.Write($"{x}, "); });
            myInts.Select(x => x * x);

            Console.WriteLine("Given a list of strings, write a LINQ query to count how many times each string appears in the list.");
            Console.WriteLine("Print the list:");
            wordList.ToList().ForEach(x => { Console.Write($"{x}, "); });
            //var distinctRemoved =
            var wordCounts = wordList.GroupBy(x => x, StringComparer.OrdinalIgnoreCase).Select(group => new
            {
                Word = group.Key,
                Count = group.Count()
            }).OrderByDescending(x => x.Count);

            Console.WriteLine("Word Counts");
            Console.WriteLine(string.Join("\n", wordCounts.Select(item => $"{item.Word}: {item.Count}")));

            //Create a list of products(with properties Name, Price, and Category). Use LINQ to find the most expensive product in each category.

            List<Product> products = new List<Product>
            {
                new Product("C# for Dummies", 1.99, "Books"),
                new Product("F# for Dummies", 2.99, "Books"),
                new Product("Dove soap", 3.99, "Toiletries"),
                new Product("HP Laptop", 1293.99, "Computers")
            };

            var productCategories = products.GroupBy(p => p.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    MostExpensiveProduct = group.OrderByDescending(p => p.Price).First()
                });


            Console.WriteLine("\nMost Expensive Product in Each Category");
            productCategories.ToList().ForEach(item =>
            {
                Console.WriteLine($"\tCategory: {item.Category} \n\tProduct: {item.MostExpensiveProduct.Name} \n\tPrice: {item.MostExpensiveProduct.Price:C2}\n"
            );

                //Given a string, use LINQ to count the number of vowels in it.


                //Create a list of dates.Use LINQ to find all dates that fall on a weekend.
                //Given a list of integers, use LINQ to find the second largest number.
                //Create a list of students(with properties Name and Grades, where Grades is a list of integers).Use LINQ to find all students with an average grade above 80.
            });
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
