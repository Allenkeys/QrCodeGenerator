using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QrCodeGenerator.DAL.Entities;

namespace QrCodeGenerator.BLL.Interfaces
{
    internal interface IUserService
    {
        void Create();
        IEnumerable<User> GetUsers();
        Task<IEnumerable<User>> GetUsersWithQrCodeAsync();
    }
}
