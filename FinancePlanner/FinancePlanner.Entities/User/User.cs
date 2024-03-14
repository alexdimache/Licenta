namespace FinancePlanner.Entities.User
{
    public class User: Entity
    {
        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}