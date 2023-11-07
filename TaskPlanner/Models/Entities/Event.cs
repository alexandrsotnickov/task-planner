namespace TaskPlanner.Models.Entities
{
    public class Event /*: CalendarEntry*/
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        //public DateTime StartDate { get; set; } = DateTime.Now;
        //public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
