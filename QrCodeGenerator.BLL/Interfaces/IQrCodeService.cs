using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QrCodeGenerator.DAL.Entities;

namespace QrCodeGenerator.BLL.Interfaces
{
    internal interface IQrCodeService
    {
        void AddOrUpdateAsync(QrCode model);
        void DeleteQrCode(User userId, QrCode codeId);
        QrCode GetQrCode(User userId, QrCode codeId);
        IEnumerable<QrCode> GetAllQrCode();
    }
}
