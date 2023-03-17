using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QrCodeGenerator.BLL.Dtos;
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
            _userRepo = _unitOfWork.GetRepository<User>();

        }

        public async Task Create(CreateUserVM model)
        {
            User user = await _userRepo.GetSingleByAsync(u => u.Id == model.Id);

            if (user == null)
            {
                await _userRepo.AddAsync(new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Email = model.Email,
                    Password = model.Password,
                    QrCodes = new List<QrCode>()
                });
                //await _unitOfWork.SaveChangesAsync();
                await _userRepo.SaveAsync();
            }
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return _userRepo.GetAllAsync();
        }

        public async Task<IEnumerable<UsersWithQrVM>> GetUsersWithQrCodeAsync()
        {
            return (await _userRepo.GetByAsync(include: u => u.Include(q => q.QrCodes))).Select(u => new UsersWithQrVM
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                QrCodes = (IEnumerable<QrCode>)u.QrCodes.Select(q => new QrCodeVM
                {
                    Code = q.Code,
                    Title = q.Title
                })
            });
        }
    }
}