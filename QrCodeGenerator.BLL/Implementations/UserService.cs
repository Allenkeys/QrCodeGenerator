using System.Collections.Generic;
using System.Threading.Tasks;
using QrCodeGenerator.BLL.Interfaces;
using QrCodeGenerator.DAL.Entities;
using QrCodeGenerator.DAL.Repository;
using TodoList.BLL.Models;

namespace QrCodeGenerator.BLL.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<User> _userRepo;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepo = unitOfWork.GetRepository<User>();
        }

        public void Create(CreateUserVM model)
        {
            _userRepo.AddAsync(new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                Email = model.Email,
                Password = model.Password,
                QrCodes = new List<QrCode>()
            });
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return _userRepo.GetAllAsync();
        }

        public Task<IEnumerable<User>> GetUsersWithQrCodeAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}