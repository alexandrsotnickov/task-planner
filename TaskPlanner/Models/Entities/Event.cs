namespace TaskPlanner.Models.Entities
{
    public class Event : CalendarEntry
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
