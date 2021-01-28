using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    public static class EventTypeServices
    {
        public static void Add(int ID, string name) =>
           Repository.Add(new EventType(ID, name));
        public static void Delete(int eventTypeID) =>
            Repository.Delete<EventType>(eventTypeID);
        public static void Update(int ID, string newName) =>
            Repository.Update<EventType>(new EventType(ID, newName));
    }
}
