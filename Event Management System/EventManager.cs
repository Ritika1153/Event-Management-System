using Event_Management_System.Models;

namespace Event_Management_System;
    public partial class EventManager
    {
        private List<Event> Events = new();
        private int _nextId = 1;
    }