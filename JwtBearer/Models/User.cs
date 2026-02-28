namespace JwtBearer.Models
{
    public record User (int Id, string Username, string Password, List<string> Roles);
}
