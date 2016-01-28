using System;

namespace EventMaker.Model
{
    public class Event
    {
        public Event(DateTime dateTime, int id, string description, string name, string place)
        {
            DateTime = dateTime;
            Id = id;
            Description = description;
            Name = name;
            Place = place;
        }

        public DateTime DateTime { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public override string ToString()
        {
            return $"DateTime: {DateTime}, Id: {Id}, Description: {Description}, Name: {Name}, Place: {Place}";
        }
    }
}