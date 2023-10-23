using TaskPlanner.Models.Entities;

namespace TaskPlanner.ViewModels
{
    public class DayViewModel
    {
        public DateTime Date { get; set; }
        public bool IsNotCurrentMonth { get; set; }
        public bool IsWeekendOrHoliday { get; set; }
        public bool IsToday { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}
