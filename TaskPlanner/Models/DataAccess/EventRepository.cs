using TaskPlanner.Models.Entities;
using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.DataAccess
{
    public class EventRepository : IEventRepository
    {
        private readonly IEnumerable<Event> events = new Event[]
    {
      new Event() { Id = 1, StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 3, 15, 0, 0), Name = "Отдать кота" },
      new Event() { Id = 2, StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 7, 6, 30, 0), Name = "Забрать кота" },
      new Event() { Id = 3, StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21, 8, 0, 0), Name = "Сделать что-то еще" }
    };

        public IEnumerable<Event> FilteredByDate(DateTime date)
        {
            return this.events.Where(e => e.StartDate.Date == date.Date);
        }
    }
}
}
