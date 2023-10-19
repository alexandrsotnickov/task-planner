using Microsoft.EntityFrameworkCore;
using TaskPlanner.Models.Entities;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<CalendarEntry> CalendarEntries { get; set; }
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Note> Notes { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Calendar>().ToTable("Calendars");
        modelBuilder.Entity<CalendarEntry>().ToTable("calendarEntries");
        modelBuilder.Entity<Challenge>().ToTable("Challenges");
        modelBuilder.Entity<Event>().ToTable("Events");
        modelBuilder.Entity<Note>().ToTable("Notes");
    }

}