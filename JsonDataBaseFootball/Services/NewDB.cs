using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    static public class NewDB
    {
        public static void GenerateNewDB()
        {
            Storage.Save(new FootballerSearch(0, "Sharapov"));
            Storage.Save(new FootballerSearch(1, "Kirjakov"));
            Storage.Save(new FootballerSearch(2, "Arshavin"));
            Storage.Save(new FootballerSearch(3, "Messi"));
            Storage.Save(new FootballerSearch(4, "Ronaldy"));

            Storage.Save(new FootballerTeamComposition(0, 1, 1, 0));
            Storage.Save(new FootballerTeamComposition(1, 2, 1, 0));
            Storage.Save(new FootballerTeamComposition(2, 3, 1, 1));
            Storage.Save(new FootballerTeamComposition(3, 4, 2, 2));

            Storage.Save(new TeamCompositionType(0, "Osnovnoy"));
            Storage.Save(new TeamCompositionType(2, "Vtoroy Sostav"));

            Storage.Save(new TeamComposition(0, "Imperskiy", 0));
            Storage.Save(new TeamComposition(1, "Maloletnie Debils", 1));
            Storage.Save(new TeamComposition(2, "road to the drim!", 1));

            Storage.Save(new EventType(0, "Match"));
            Storage.Save(new EventType(1, "Tovarish match"));
            Storage.Save(new EventType(2, "Trenirovka"));
            Storage.Save(new EventType(3, "individual trenirovka"));
        }
        public static void GenerateFiles()
        {
            // запись в файл
            using (FileStream fstream = new FileStream("EventType.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
            // запись в файл
            using (FileStream fstream = new FileStream("Footballer.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }// запись в файл
            using (FileStream fstream = new FileStream("FootballerTeamComposition.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }// запись в файл
            using (FileStream fstream = new FileStream("TeamComposition.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }// запись в файл
            using (FileStream fstream = new FileStream("TeamCompositionType.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }// запись в файл
            using (FileStream fstream = new FileStream("Event.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }
    }
}
