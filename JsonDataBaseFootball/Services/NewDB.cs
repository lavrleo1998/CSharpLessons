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
            Storage.Save(new Footballer(0, "Footboller1"));
            Storage.Save(new Footballer(1, "Footboller2"));
            Storage.Save(new Footballer(2, "Footboller3"));
            Storage.Save(new Footballer(3, "Footboller4"));
            Storage.Save(new Footballer(4, "Footboller5"));

            Storage.Save(new FootballerTeamComposition(0, 1, 1, 0));
            Storage.Save(new FootballerTeamComposition(1, 2, 1, 0));
            Storage.Save(new FootballerTeamComposition(2, 3, 1, 1));
            Storage.Save(new FootballerTeamComposition(3, 4, 2, 2));

            Storage.Save(new TeamCompositionType(0, "Osnovnoy"));
            Storage.Save(new TeamCompositionType(1, "Vtoroy Sostav"));

            Storage.Save(new TeamComposition(0, "Imperskiy", 0));
            Storage.Save(new TeamComposition(1, "Maloletnie Debils", 1));
            Storage.Save(new TeamComposition(2, "road to the drim!", 1));

            Storage.Save(new EventType(0, "Match"));
            Storage.Save(new EventType(1, "Tovarish match"));
            Storage.Save(new EventType(2, "Trenirovka"));
            Storage.Save(new EventType(3, "individual trenirovka"));

            DateTime dateTime = new DateTime( 2015, 7, 20, 18, 30, 25);
            Storage.Save(new Event(0, dateTime, 0, 0));
            Storage.Save(new Event(1, dateTime, 1, 1));
            Storage.Save(new Event(2, dateTime, 2, 0));
            Storage.Save(new Event(3, dateTime, 3, 1));
            Storage.Save(new Event(4, dateTime, 4, 2));

            Storage.Save(new Trainer(0, "Trainer1"));
            Storage.Save(new Trainer(1, "Trainer2"));
            Storage.Save(new Trainer(2, "Trainer3"));

            Storage.Save(new Position(0, "Goalkeeper"));
            Storage.Save(new Position(1, "Forward"));
            Storage.Save(new Position(2, "Quarterback"));
        }
        public static void GenerateFiles()
        {

            // запись в файл
            using (FileStream fstream = new FileStream("Position.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("Trainer.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            // запись в файл
            using (FileStream fstream = new FileStream("EventType.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            // запись в файл
            using (FileStream fstream = new FileStream("Footballer.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("FootballerTeamComposition.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("TeamComposition.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("TeamCompositionType.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("Event.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
