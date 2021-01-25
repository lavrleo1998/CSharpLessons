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
            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25);
            footballers.Add(new Footballer("A1", "AA1", date1, 20000, 307));
            footballers.Add(new Footballer("A2", "AA2", date1, 2820000, 20));
            footballers.Add(new Footballer("A3", "AA3", date1, 205420, 21));
            footballers.Add(new Footballer("A4", "AA4", date1,544520, 20));
            footballers.Add(new Footballer("A5", "AA5", date1, 452045200, 247));
            footballers.Add(new Footballer("A6", "AA6", date1, 545438700, 35));
            footballers.Add(new Footballer("A7", "AA7", date1, 73000, 20));
            footballers.Add(new Footballer("A8", "AA8", date1, 273636770, 64));
            footballers.Add(new Footballer("A9", "AA9", date1, 20000, 287));
            footballers.Add(new Footballer("A10", "AA10", date1, 2763600, 200));
            var selectedFootballers = from footballer in footballers where footballer.Salary < 20000 select footballer;
            foreach (var item in selectedFootballers)
            {
                Console.WriteLine(item);
            }
            




            Console.ReadKey();
        }
        class Footballer
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
