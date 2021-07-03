using UnitOfWorkExample.UnitOfWork.Models;

namespace UnitOfWorkExample.Services.Dto
{
    public class UserDto
    {
        public string Name { get; }
        public bool IsAdministrator { get; }
        public string Mail { get; }
        public string Username { get; }
        public string Password { get; }

        public UserDto()
        {
            
        }
        public UserDto(string name)
        {
            Name = name;
        }

        public UserDto(User user)
        {
            this.Name = user.Name;
            this.IsAdministrator = user.IsAdministrator;
            this.Username = user.Username;
            this.Mail = user.Mail;
            this.Password = user.Password;
        }
    }
}