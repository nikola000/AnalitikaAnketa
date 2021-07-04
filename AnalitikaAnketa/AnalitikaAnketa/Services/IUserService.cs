using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;
using UnitOfWorkExample.UnitOfWork.Models;

namespace UnitOfWorkExample.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync(string term);
        List<User> GetUsersDataGrid();
        Task<UserDto> CheckUser(string username,string password); 
    }
}