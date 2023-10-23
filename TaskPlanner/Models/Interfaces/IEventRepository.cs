using TaskPlanner.Models.Entities;

namespace TaskPlanner.Models.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable<Event> FilteredByDate(DateTime date);
    }
}
