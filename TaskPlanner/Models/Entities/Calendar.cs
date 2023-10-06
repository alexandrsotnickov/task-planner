using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.Entities
{
    public class Calendar
    {
        public int Id { get; set; }
        public List<IEntry> Entries { get; set; } = new List<IEntry>();

        public string Name { get; set; } = "Новый календарь";

    }
}
