using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;
using UnitOfWorkExample.UnitOfWork.Models;

namespace UnitOfWorkExample.Services
{
    public interface IUserService
    {
        List<UserDto> GetUsersAsync(string term);
        UserDto CheckUser(string username,string password);
        BindingList<User> GetUsersDataGrid();
    }
}