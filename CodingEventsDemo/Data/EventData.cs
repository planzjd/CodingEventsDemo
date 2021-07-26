using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data
{
    public class EventData
    {
        //store events
        private static Dictionary<int, Event> _events = new Dictionary<int, Event>();

        //add events
        public static void Add(Event newEvent)
        {
            _events.Add(newEvent.Id, newEvent);
        }

        //retreive the events
        public static IEnumerable<Event> GetAll()
        {
            return _events.Values;
        }

        //retreive a single event
        public static Event GetById(int id)
        {
            return _events[id];
        }

        //remove an event
        public static void Remove(int id)
        {
            _events.Remove(id);
        }

        internal static void Edit(int eventId, string name, string description)
        {
            throw new NotImplementedException();
        }
        
    }
}
