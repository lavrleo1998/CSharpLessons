using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Repository
{
    public static class Storage
    {
        public static void Save<T>(T objectForJSON)
        {
            //Получаем данные из файла в лист
            List<T> write = Get<T>();
            //добавляем новый объект в лист
            write.Add(objectForJSON);
            //Записываем обновленный лист в файл
            Write(JsonConvert.SerializeObject(write), typeof(T).Name + ".txt");
        }
        public static List<T> Get<T>()
        {
            //Получаем данные из файла
            var str = Read(typeof(T).Name + ".txt");
            //десериализация до объекта
            var result = JsonConvert.DeserializeObject<List<T>>(str);
            //ВОзвращение объекта
            return result;
        }
        private static void Write(string stringToWrite, string fileAddress)
        {
            using (StreamWriter file = new StreamWriter(fileAddress, false, System.Text.Encoding.Default))
            {
                file.WriteLine(stringToWrite);
                file.Close();
            }
        }
        private static string Read(string fileAddress)
        {
            using (StreamReader file = new StreamReader(fileAddress))
            {
                string result = file.ReadToEnd();
                file.Close();
                return result;
            }
        }


    }
}
