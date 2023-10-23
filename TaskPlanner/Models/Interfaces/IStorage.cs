namespace TaskPlanner.Models.Interfaces
{
    public interface IStorage
    {
        IEventRepository EventRepository { get; }
    }
}
