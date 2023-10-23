namespace TaskPlanner.Models.Entities
{
    public class Calendars
    {
        public int Id { get; set; }
        public List<Calendar> CalendarsList { get; set; } = new List<Calendar>();
    }
}
