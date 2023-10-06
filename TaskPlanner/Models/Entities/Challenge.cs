using TaskPlanner.Models.Enums;

namespace TaskPlanner.Models.Entities
{
    public class Challenge : CalendarEntry
    {
        public DateTime? Deadline { get; set; }
        public ChallengeStatus Status { get; set; } = ChallengeStatus.Created;

    }
}
