﻿using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.Entities
{
    public class Storage : IStorage
    {
        public IEventRepository EventRepository { get; private set; }

        public Storage()
        {
            this.EventRepository = new EventRepository();
        }
    }
}
