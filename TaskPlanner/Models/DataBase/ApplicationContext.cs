using Microsoft.EntityFrameworkCore;
using TaskPlanner.Models.Entities;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Calendar> Calendars => Set<Calendar>();
    public DbSet<CalendarEntry> calendarEntries => Set<CalendarEntry>();
    public DbSet<Challenge> challenges => Set<Challenge>();
    public DbSet<Event> events => Set<Event>();
    public DbSet<Note> notes => Set<Note>();
  
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS);Database=helloappdb;Trusted_Connection=True;");
    }
}