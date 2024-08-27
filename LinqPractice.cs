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
        //    Console.WriteLine("Given a list of integers, write a LINQ query to find all even numbers.");
        //    var ints = Enumerable.Range(1, 100);
        //    var evens = ints.Where(x => x % 2 == 0);
        //    evens.ToList().ForEach(x => { Console.Write(x + ", "); });

        //    Console.WriteLine("1.Create a list of strings and use LINQ to find all strings that start with the letter 'A'");
        //    var strs = new List<string> { "some", "strings", "in", "a", "short", "annoying", "list", "Aha!" };
        //    Console.WriteLine("\n\nStrings Beginning with 'a'\n");

        //    //Mine - BUT DOES NOT catch capitals! Does now that I've added it, but didn't before.
        //    var strsWithAStart = strs.Where(x => x.StartsWith("a", StringComparison.OrdinalIgnoreCase));
        //    strsWithAStart.ToList().ForEach(x => { Console.WriteLine(x); });

        //    //Perplexity shortened it to:
        //    strs.Where(x => x.StartsWith("a", StringComparison.OrdinalIgnoreCase))
        //        .ToList()
        //        .ForEach(Console.WriteLine);

        //    Console.WriteLine("2. Given a list of people(with properties Name and Age), find the average age of all people over 18.");

        //    //Create people
        //    //Add people to list
        //    var people = new List<Person> {
        //    new Person("Johnny", 21),
        //    new Person("John", 100),
        //    new Person("Jo", 10),
        //    new Person("Josh", 70)
        //};

        //    //Filter to over 18s AND calculate average age in one.
        //    var over18s = people
        //        .Where(x => x.Age >= 18)
        //        .Average(x => x.Age);
        //    Console.WriteLine($"Average age of over 18s in list: {over18s:F2}");

        //    //Create two lists of integers.Write a LINQ query to find all numbers that appear in both lists.
        //    var ints1 = Enumerable.Range(0, 100);
        //    var ints2 = Enumerable.Range(-100, 200);

        //    //Mine
        //    var inBoth = Enumerable.Intersect(ints1, ints2);
        //    Console.Write("\nIn both lists: ");
        //    inBoth.ToList().ForEach(x => Console.Write($"{x}, "));
        //    //Perplexity
        //    var inBothPerplexity = ints1.Intersect(ints2);
        //    Console.Write("\nIn both lists: ");
        //    inBothPerplexity.ToList().ForEach(x => Console.Write($"{x}, "));

        //    Console.WriteLine("Given a list of words, use LINQ to find the longest word.");
        //    var wordList = new List<string>
        //    {
        //        "Apple", "banana", "Orange", "Grapefruit", "watermelon", "Blueberry", "strawberry", "Pineapple", "blood-orange", "well-being", "Quick",
        //        "extraordinary", "chocolate-chip", "howl", "scorn", "Blueberry", "Pineapple"
        //    };

        //    var longestWordSort = wordList
        //        .OrderByDescending(x => x.Length)
        //        .First();
        //    Console.WriteLine($"\nLongest word is: {longestWordSort}");

        //    Console.WriteLine("Create a list of integers and use LINQ to square each number and return a new list.");
        //    var myInts = Enumerable.Range(0, 25);
        //    Console.WriteLine("\nRange of ints: ");
        //    myInts.ToList().ForEach(x => { Console.Write($"{x}, "); });
        //    Console.WriteLine("\nSquared ints: ");
        //    myInts.Select(x => x * x).ToList().ForEach(x => { Console.Write($"{x}, "); });
        //    myInts.Select(x => x * x);

        //    Console.WriteLine("Given a list of strings, write a LINQ query to count how many times each string appears in the list.");
        //    Console.WriteLine("Print the list:");
        //    wordList.ToList().ForEach(x => { Console.Write($"{x}, "); });
        //    //var distinctRemoved =
        //    var wordCounts = wordList.GroupBy(x => x, StringComparer.OrdinalIgnoreCase).Select(group => new
        //    {
        //        Word = group.Key,
        //        Count = group.Count()
        //    }).OrderByDescending(x => x.Count);

        //    Console.WriteLine("Word Counts");
        //    Console.WriteLine(string.Join("\n", wordCounts.Select(item => $"{item.Word}: {item.Count}")));

        //    //Create a list of products(with properties Name, Price, and Category). Use LINQ to find the most expensive product in each category.

        //    List<Product> products = new List<Product>
        //    {
        //        new Product("C# for Dummies", 1.99, "Books"),
        //        new Product("F# for Dummies", 2.99, "Books"),
        //        new Product("Dove soap", 3.99, "Toiletries"),
        //        new Product("HP Laptop", 1293.99, "Computers")
        //    };

        //    var productCategories = products.GroupBy(p => p.Category)
        //        .Select(group => new
        //        {
        //            Category = group.Key,
        //            MostExpensiveProduct = group.OrderByDescending(p => p.Price).First()
        //        });

        //    Console.WriteLine("\nMost Expensive Product in Each Category");
        //    productCategories.ToList().ForEach(item =>
        //    {
        //        Console.WriteLine($"\tCategory: {item.Category} \n\tProduct: {item.MostExpensiveProduct.Name} \n\tPrice: {item.MostExpensiveProduct.Price:C2}\n"
        //    );               
        //    });

        //    //Given a string, use LINQ to count the number of vowels in it.
        //    List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        //    string? input = "";
        //    do
        //    {
        //        Console.WriteLine("Please input some text:");
        //        input = Console.ReadLine();

        //        if (System.String.IsNullOrEmpty(input))
        //        {
        //            Console.WriteLine("Invalid input. Please try again");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Your input was: {input}");
        //            // Count the number of vowels in the input
        //            int vowelCount = input.ToLower().Count(c => vowels.Contains(c));
        //            Console.WriteLine($"Number of vowels in your input: {vowelCount}");
        //        }
        //    } while (System.String.IsNullOrWhiteSpace(input));

        //    List<string> commonWords = new List<string> { "an", "the", "is", "in", "at", "of", "and", "to", "with", "for" };
        //    Console.WriteLine("\nPlease input some text for common word identification:");
        //    string? inputty = Console.ReadLine();

        //    if (string.IsNullOrWhiteSpace(input))
        //    {
        //        Console.WriteLine("Invalid input. Please try again");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Your input was: {inputty}");
        //        // Convert input to lowercase and split into words
        //        var inputWords = inputty.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        //        // Count occurrences of each common word
        //        var wordCount = commonWords.ToDictionary(
        //            word => word,
        //            word => inputWords.Count(w => w == word)
        //        );

        //        Console.WriteLine("Common word counts in your input:");
        //        foreach (var kvp in wordCount)
        //        {
        //            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //        }
        //    }

            //Create a list of dates.Use LINQ to find all dates that fall on a weekend.
            List<DateOnly> dates = new List<DateOnly>
            {
                new DateOnly(2000, 1, 1),
                new DateOnly(2011, 11, 11),
                new DateOnly(2021, 3, 3),
                new DateOnly(2024, 8, 3),
            };
            
            List<DayOfWeek> weekend = new List<DayOfWeek> {  
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };

            var weekendDates = dates.Where(date => weekend.Contains(date.DayOfWeek));
            weekendDates.ToList().ForEach(weekendDate => { Console.WriteLine($"Weekend date found: {weekendDate}"); });

            //Given a list of integers, use LINQ to find the second largest number.

            List<int> myInts2 = new List<int> {527, 18, 763, 92, 430, 501, 654, 219, 876, 345,
    12, 789, 234, 467, 890, 123, 678, 345, 456, 890,
    11, 444, 333, 222, 888, 900, 1000, 555, 333, 777,
    22, 66, 44, 77, 88, 99, 101, 202, 303, 404,
    505, 606, 707, 808, 909, 100, 200, 300, 400, 500,
    600, 700, 800, 900, 150, 250, 350, 450, 550, 650,
    750, 850, 950, 37, 64, 89, 912, 213, 789, 456,
    321, 654, 987, 123, 456, 789, 852, 741, 963, 159,
    753, 951, 852, 654, 321, 147, 258, 369, 741, 852,
    963, 159, 753, 951, 852, 654, 321, 147, 258, 369 };
            
            int last = myInts2
                .Distinct()
                .OrderByDescending(x => x)
                .FirstOrDefault();
            Console.WriteLine($"Last value: {last}");

            int secondLast = myInts2
                .Distinct()
                .OrderByDescending(x => x)
                .ElementAtOrDefault(1);
            Console.WriteLine($"Second Last value: {secondLast}");

            var ListsAreSame = EqualityComparer<List<int>>.Default.Equals( myInts2, myInts2);

            //Create a list of students(with properties Name and Grades, where Grades is a list of integers).Use LINQ to find all students with an average grade above 40.

            const int passMark = 40;

            List<Student> students = new List<Student>
            {
                new Student("John", new List<int>{10,20,30}),
                new Student("Steve", new List<int>{40,50,90}),
                new Student("Bryan", new List<int>{90,0,100}),
            };

            Console.WriteLine($"Students with an average greater than {passMark}");
            students.Where
                (s => s.Grades.Average() >= passMark)
                .ToList()
                .ForEach(s => Console.WriteLine($"\tName: {s.Name}, \n\tAverage grade score: {s.Grades.Average():F2}%"));

            //Random class sketching
            var rand = new Random();
            var power = rand.Next(5);
            Console.WriteLine($"Exponent: {power}");
            var raiseToThePower = Math.Exp(power);
            Console.WriteLine($"Random number {power} raised to the power of exponent {raiseToThePower} is: {raiseToThePower}");
            var squared = myInts2.Select(i => i * i);
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

    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, List<int> grades)
        {
            Name = name;
            Grades = grades;
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
