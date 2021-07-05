using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkExample.Services.Dto;
using UnitOfWorkExample.UnitOfWork;
using UnitOfWorkExample.UnitOfWork.Models;
using System.Linq;

namespace UnitOfWorkExample.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public UserDto CheckUser(string username, string password)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var users = unitOfWork.Repository().Find<User>(x => x.Username == username && x.Password == password);
                if (users.FirstOrDefault() == null)
                {
                    return null;
                }
                var userKojiPostoji = users.FirstOrDefault();

                return new UserDto(userKojiPostoji);
            }
        }

        public List<UserDto> GetUsersAsync(string term)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var users = unitOfWork.Repository().Find<User>(x => x.Name.Contains(term));
                return users.Select(user => new UserDto(user.Name)).ToList();
            }
        }
    }
}
