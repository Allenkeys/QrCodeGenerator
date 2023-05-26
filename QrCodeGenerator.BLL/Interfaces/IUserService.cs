using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QrCodeGenerator.BLL.Dtos;
using QrCodeGenerator.DAL.Entities;
using TodoList.BLL.Models;

namespace QrCodeGenerator.BLL.Interfaces
{
    public interface IUserService
    {
        Task Create(CreateUserVM model);
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<UsersWithQrVM>> GetUsersWithQrCodeAsync();
    }
}
