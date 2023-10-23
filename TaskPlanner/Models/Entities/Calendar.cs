using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.Entities
{
    public class Calendar
    {
        public int Id { get; set; }
        public List<CalendarEntry> Entries { get; set; } = new List<CalendarEntry>();

    }
}
