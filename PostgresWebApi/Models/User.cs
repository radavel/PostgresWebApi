namespace PostgresWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public int Age { get; set; }
    }
}