namespace LVRCalculatorApp.Models
{
    public class UserToken
    {
        public int Id { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public User User { get; set; } = new User();
    }
}
