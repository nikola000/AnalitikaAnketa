using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;

namespace UnitOfWorkExample.Services
{
    public interface IUserService
    {
        List<UserDto> GetUsersAsync(string term);
        UserDto CheckUser(string username,string password); 
    }
}