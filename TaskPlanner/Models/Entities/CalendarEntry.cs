using System.ComponentModel.DataAnnotations;
using TaskPlanner.Models.Enums;
using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.Entities
{
    public class CalendarEntry: IEntry
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = "Новая задача";

    }
}
