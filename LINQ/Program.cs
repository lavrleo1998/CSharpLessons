using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Repository;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from t in teams // определяем каждый объект из teams как t
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            
            
            List<Footballer> footballers = Storage.Get<Footballer>();
            var selectedFootballers = from footballer in footballers  where footballer.ID < 2 select footballer;

            selectedFootballers = footballers.Where(f => f.ID < 2).OrderBy(x=> x.Name);
                Console.ReadKey();






        }
    }
}
