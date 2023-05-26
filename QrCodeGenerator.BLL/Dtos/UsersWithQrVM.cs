using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QrCodeGenerator.DAL.Entities;

namespace QrCodeGenerator.BLL.Dtos
{
    public class UsersWithQrVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<QrCode> QrCodes { get; set; }
    }
}
