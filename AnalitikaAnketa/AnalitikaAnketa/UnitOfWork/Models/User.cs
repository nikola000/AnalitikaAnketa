namespace UnitOfWorkExample.UnitOfWork.Models
{
    public class User
    {
        public int Id { get; set; }
        // Add model properties here
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
    }
}