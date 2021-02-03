using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;

namespace JsonDataBaseFootball.DataBase
{
    public static class Repository
    {
        public static void Add<T>(T objectForJSON)
        {
            //Получаем данные из файла в лист
            List<T> newList = Get<T>();
            //добавляем новый объект в лист
            newList.Add(objectForJSON);
            //Записываем обновленный лист в файл
            Storage.Write(JsonConvert.SerializeObject(newList), typeof(T).Name + ".json");
            //string jsonString = JsonSerializer.Serialize<>(weatherForecast);
        }

        public static void Update<T>(T obj) where T : Entity
        {
            var listForChange = Repository.Get<T>();
            /////баг вот тут, из-за неотслеживаемых айдтшников,
            ///но они же могут быть не нумерными, так что надо добавить
            ///поиск догосамого объекта и в нем менять, не забудь исправить
            listForChange[obj.ID] = obj;

            Storage.Write(JsonConvert.SerializeObject(listForChange), typeof(T).Name + ".json");
        }

        public static void Delete<T>(int ID) where T : Entity
        {
            var listForChange = Repository.Get<T>();

            listForChange.Remove(listForChange.Where(x => x.ID == ID).First());

            Storage.Write(JsonConvert.SerializeObject(listForChange), typeof(T).Name + ".json");
        }

        

        public static List<T> Get<T>()
        {
            //Получаем данные из файла
            var str = Storage.Read(typeof(T).Name + ".json");
            //десериализация до объекта
            var result = JsonConvert.DeserializeObject<List<T>>(str);
            //ВОзвращение объекта
            return result;
        }


    }
}
