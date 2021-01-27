using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.DataBase
{
    static public class NewDB
    {
        public static void GenerateNewDB()
        {
            //Футболисты первого состава
            Repository.Save(new Footballer(0, "Footboller 0"));
            Repository.Save(new Footballer(1, "Footboller 1"));
            Repository.Save(new Footballer(2, "Footboller 2"));
            Repository.Save(new Footballer(3, "Footboller 3"));
            //Футболисты второго состава
            Repository.Save(new Footballer(4, "Footboller 4"));
            Repository.Save(new Footballer(5, "Footboller 5"));
            Repository.Save(new Footballer(6, "Footboller 6"));
            Repository.Save(new Footballer(7, "Footboller 7"));

            //Типы составов
            Repository.Save(new TeamType(0, "Osnovnoy"));
            Repository.Save(new TeamType(1, "Vtoroy Sostav"));

            //Составы для основного
            Repository.Save(new Team(0, "Атака основным", 0));
            Repository.Save(new Team(1, "Защита основным", 0));
            Repository.Save(new Team(2, "Универсальный основной", 0));
            //Составы для запасного
            Repository.Save(new Team(3, "Атака основным", 1));
            Repository.Save(new Team(4, "Защита основным", 1));
            Repository.Save(new Team(5, "Универсальный основной", 1));

            //Тренера
            Repository.Save(new Trainer(0, "Trainer 0"));
            Repository.Save(new Trainer(1, "Trainer 1"));
            Repository.Save(new Trainer(2, "Trainer 2"));

            //Позиции 
            Repository.Save(new Position(0, "Goalkeeper"));
            Repository.Save(new Position(1, "Forward"));
            Repository.Save(new Position(2, "Quarterback"));

            //Типы событий
            Repository.Save(new EventType(0, "Матч"));
            Repository.Save(new EventType(1, "Товарищеский матч"));
            Repository.Save(new EventType(2, "Тренировка"));
            Repository.Save(new EventType(3, "Индивидуальная тренировка"));



            //Отношения футболисты - составы/команды
            Repository.Save(new FootballerTeam(0, 0, 0, 0));
            Repository.Save(new FootballerTeam(1, 1, 0, 1));
            Repository.Save(new FootballerTeam(2, 2, 0, 2));
            Repository.Save(new FootballerTeam(3, 3, 0, 0));

            Repository.Save(new FootballerTeam(4, 4, 3, 0));
            Repository.Save(new FootballerTeam(5, 5, 3, 1));
            Repository.Save(new FootballerTeam(6, 6, 3, 2));
            Repository.Save(new FootballerTeam(7, 7, 3, 0));

            Repository.Save(new FootballerTeam(0, 0, 1, 0));
            Repository.Save(new FootballerTeam(1, 1, 1, 1));
            Repository.Save(new FootballerTeam(2, 2, 1, 2));
            Repository.Save(new FootballerTeam(3, 3, 1, 0));

            Repository.Save(new FootballerTeam(4, 4, 4, 0));
            Repository.Save(new FootballerTeam(5, 5, 4, 1));
            Repository.Save(new FootballerTeam(6, 6, 4, 2));
            Repository.Save(new FootballerTeam(7, 7, 4, 0));




            //События
            DateTime dateTime = new DateTime( 2015, 7, 20, 18, 30, 25);
            Repository.Save(new Event(0, dateTime, 0, 0));
            Repository.Save(new Event(1, dateTime, 1, 1));
            Repository.Save(new Event(2, dateTime, 2, 0));
            Repository.Save(new Event(3, dateTime, 3, 1));
            Repository.Save(new Event(4, dateTime, 4, 2));
























        }
        public static void GenerateFiles()
        {

            // запись в файл
            using (FileStream fstream = new FileStream("Position.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("Trainer.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            // запись в файл
            using (FileStream fstream = new FileStream("EventType.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            // запись в файл
            using (FileStream fstream = new FileStream("Footballer.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("FootballerTeam.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("Team.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("TeamType.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }// запись в файл
            using (FileStream fstream = new FileStream("Event.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes("[]");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
