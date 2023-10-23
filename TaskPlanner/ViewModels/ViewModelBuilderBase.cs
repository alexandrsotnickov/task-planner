using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.ViewModels
{
    public abstract class ViewModelBuilderBase
    {
        protected IStorage Storage { get; private set; }

        public ViewModelBuilderBase(IStorage storage)
        {
            this.Storage = storage;
        }
    }
}
