using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    public static class Get
    {
        public static List<Event> EventByFilter(int? ID, DateTime? dateTime, int? eventTypeId, int? teamCompositionID)
        {
            var listEvent = Storage.Get<Event>();
            var returnListEvent = new List<Event>();

            foreach (var itemEvent in listEvent)
            {
                if ((ID == null || itemEvent.EventTypeID == ID)
                    && (dateTime == null || itemEvent.DateTime == dateTime)
                    && (eventTypeId == null || itemEvent.EventTypeID == eventTypeId)
                    && (teamCompositionID == null || itemEvent.EventTypeID == teamCompositionID))
                {
                    returnListEvent.Add(itemEvent);
                }
            }
            return returnListEvent;
        }
        public static List<EventType> EventTypeByFilter(int? ID, string name)
        {
            var listEventType = Storage.Get<EventType>();
            var returnListEventType = new List<EventType>();

            foreach (var itemEvent in listEventType)
            {
                if ((ID == null || itemEvent.ID == ID)
                    && (name == null || itemEvent.Name == name))
                {
                    returnListEventType.Add(itemEvent);
                }
            }
            return returnListEventType;
        }
        public static List<Footballer> FootballerByFilter(int? ID, string name)
        {
            var listFootballer = Storage.Get<Footballer>();
            var returnListFootballer = new List<Footballer>();
            foreach (var itemFootbaler in listFootballer)
            {
                if ((ID == null || itemFootbaler.ID == ID) && (name == null || itemFootbaler.Name == name))
                {
                    returnListFootballer.Add(itemFootbaler);
                }
            }
            return returnListFootballer;
        }
        public static List<FootballerTeamComposition> FootballerTeamCompositionByFilter(int? ID, int? footbollerID, int? teamCompositionID, int? positionID)
        {
            var listFootballerTeamComposition = Storage.Get<FootballerTeamComposition>();
            var returnListFootballerTeamComposition = new List<FootballerTeamComposition>();

            foreach (var itemFootballerTeamComposition in listFootballerTeamComposition)
            {
                if ((ID == null || itemFootballerTeamComposition.ID == ID)
                    && (footbollerID == null || itemFootballerTeamComposition.FootbollerID == footbollerID)
                    && (teamCompositionID == null || itemFootballerTeamComposition.TeamCompositionID == teamCompositionID)
                    && (positionID == null || itemFootballerTeamComposition.PositionID == positionID))
                {
                    returnListFootballerTeamComposition.Add(itemFootballerTeamComposition);
                }
            }
            return returnListFootballerTeamComposition;
        }
        public static List<TeamComposition> TeamCompositionByFilter(int? ID, string name, int? teamCompositionTypeID)
        {
            var listTeamComposition = Storage.Get<TeamComposition>();
            var returnListTeamComposition = new List<TeamComposition>();

            foreach (var itemTeamComposition in listTeamComposition)
            {
                if ((ID == null || itemTeamComposition.ID == ID)
                    && (name == null || itemTeamComposition.Name == name)
                    && (teamCompositionTypeID == null || itemTeamComposition.TeamCompositionTypeID == teamCompositionTypeID))
                {
                    returnListTeamComposition.Add(itemTeamComposition);
                }
            }
            return returnListTeamComposition;
        }
        public static List<TeamCompositionType> TeamCompositionTypeByFilter(int? ID, string name)
        {
            var listTeamCompositionType = Storage.Get<TeamCompositionType>();
            var returnListTeamCompositionType = new List<TeamCompositionType>();

            foreach (var itemTeamCompositionType in listTeamCompositionType)
            {
                if ((ID == null || itemTeamCompositionType.ID == ID)
                    && (name == null || itemTeamCompositionType.Name == name))
                {
                    returnListTeamCompositionType.Add(itemTeamCompositionType);
                }
            }
            return returnListTeamCompositionType;
        }
    }
}
