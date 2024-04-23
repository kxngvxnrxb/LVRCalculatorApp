namespace LVRCalculatorApp.Models
{
    public class UserToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime DateCreated { get; set; }
        public User User { get; set; }
    }
}
