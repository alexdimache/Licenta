namespace FinancePlanner.API.Models
{
    public class UserModel
    {
        public Guid? Id { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string Token { get; set; }
    }
}