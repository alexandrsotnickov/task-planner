namespace TaskPlanner.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
