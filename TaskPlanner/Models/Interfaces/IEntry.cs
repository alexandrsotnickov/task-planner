using TaskPlanner.Models.Enums;

namespace TaskPlanner.Models.Interfaces
{
    public interface IEntry
    {
        int Id { get; set; }
        string Name { get; set; }
        
    }
}
