using System.Reflection.Metadata;
using TaskPlanner.Models.Enums;
using TaskPlanner.Models.Interfaces;

namespace TaskPlanner.Models.Entities.Factory
{
    public class EntriesFactory
    {
        public IEntry CreateEntry(EntryType selectedType)
        {

            if (selectedType == EntryType.Event)
            {
                //return new Event();
                return null;
            }
            else
            {
                return new Challenge();
            }
           
        }
    }
}
