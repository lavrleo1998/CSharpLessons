using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

                        var footballers = new List<Footballer>();
            footballers.Add(new Footballer("A", "AA7", new DateTime(2015, 7, 20, 18, 24, 25), 73000, 20));
            footballers.Add(new Footballer("b", "AA2", new DateTime(2015, 7, 21, 18, 30, 25), 2820000, 20));
            footballers.Add(new Footballer("A", "AA10", new DateTime(2015, 8, 20, 18, 30, 25), 2763600, 200));
            footballers.Add(new Footballer("A", "AA1", new DateTime(2015, 7, 20, 18, 30, 26), 20000, 307));
            footballers.Add(new Footballer("b", "AA8", new DateTime(2016, 7, 20, 18, 30, 25), 273636770, 64));
            footballers.Add(new Footballer("c", "AA5", new DateTime(2015, 4, 20, 18, 30, 25), 452045200, 247));
            footballers.Add(new Footballer("f", "AA6", new DateTime(2017, 7, 20, 18, 30, 25), 545438700, 35));
            footballers.Add(new Footballer("f", "AA3", new DateTime(2019, 7, 20, 18, 30, 25), 205420, 21));
            footballers.Add(new Footballer("c", "AA9", new DateTime(2015, 7, 20, 18, 30, 25), 20000, 287));
            footballers.Add(new Footballer("e", "AA4", new DateTime(2021, 7, 20, 18, 30, 25), 544520, 20));


            Console.WriteLine("\n------------ Where and OrderBy");
            var t1 = footballers.Where(f => f.Salary > 2000).OrderBy(x => x.Birthday);
            foreach (var item in t1)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Birthday + " " + item.Salary + " " + item.NumberOfMatches);

            }


            Console.WriteLine("\n------------ Where and OrderBy");
            footballers
                .Where(f => f.Salary > 2000)
                .OrderBy(x => x.Birthday)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} {x.Birthday}"));


            Console.WriteLine("\n------------ All");
            Console.WriteLine(footballers.All(x => x.Name != ""));


            Console.WriteLine("\n------------ Any");
            Console.WriteLine(footballers.Any(x => x.NumberOfMatches > 10));



            Console.WriteLine("\n------------GroupBy");
            footballers
                .GroupBy(x => x.Name)
                .Select(x => new { Name = x.Key, Count = x.Count() })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} {x.Count}"));

            Console.WriteLine("\n------------skip and take");

            foreach (var item in footballers
                .Skip(3)
                .Take(2)
                .Select(x => x)
                .ToArray())
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Birthday + " " + item.Salary + " " + item.NumberOfMatches);

            }




            Console.ReadKey();
        }

        public static class Controller
        {
            public static void Print(List<Footballer> prtintList)
            {

            }
        }


        public class Footballer
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; set; }
            public double Salary { get; set; }
            public int NumberOfMatches { get; set; }

            public Footballer(string name, string surname, DateTime birthday, double salary, int numberOfMatches)
            {
                this.Name = name;
                this.Surname = surname;
                this.Birthday = birthday;
                this.Salary = salary;
                this.NumberOfMatches = numberOfMatches;
            }

        }
    }
}
