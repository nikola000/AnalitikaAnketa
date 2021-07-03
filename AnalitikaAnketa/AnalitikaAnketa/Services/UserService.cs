using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;
using UnitOfWorkExample.UnitOfWork;
using UnitOfWorkExample.UnitOfWork.Models;

namespace UnitOfWorkExample.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        public async Task<List<UserDto>> GetUsersAsync(string term)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var users = await unitOfWork.Repository().FindAsync<User>(x => x.Name.Contains(term));
                return users.Select(user => new UserDto(user.Name)).ToList();
            }
        }
    }
}
