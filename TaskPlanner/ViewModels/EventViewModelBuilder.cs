using Microsoft.Identity.Client.Extensions.Msal;
using TaskPlanner.Models.Entities;
using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.ViewModels
{
    public class EventViewModelBuilder : ViewModelBuilderBase
    {
        public EventViewModelBuilder(IStorage storage) : base(storage)
        {
        }

        public EventViewModel Build(Event @event)
        {
            return new EventViewModel()
            {
                Date = @event.StartDate,
                Name = @event.Name
            };
        }
    }
}
