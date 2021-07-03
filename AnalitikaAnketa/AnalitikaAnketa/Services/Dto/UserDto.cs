namespace UnitOfWorkExample.Services.Dto
{
    public class UserDto
    {
        public string Name { get; }

        public UserDto(string name)
        {
            Name = name;
        }
    }
}