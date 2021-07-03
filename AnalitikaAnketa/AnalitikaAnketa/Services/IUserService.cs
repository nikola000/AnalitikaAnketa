using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;

namespace UnitOfWorkExample.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync(string term);
        Task<UserDto> CheckUser(string username,string password); 
    }
}