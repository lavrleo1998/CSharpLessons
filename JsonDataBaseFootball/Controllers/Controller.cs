using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Controllers
{
    public static class Controller
    {
        public static void PrintFootboller()
        {
            Console.WriteLine("Введите имя футболиста");
            string nameFootboller = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------");
            List<Footballer> list = Get.FootballerByFilter(1, nameFootboller);
            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item.ID + " " + item.Name);
            }
        }
    }
}
