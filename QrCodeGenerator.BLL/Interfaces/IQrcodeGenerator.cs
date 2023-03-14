using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace QrCodeGenerator.BLL.Interfaces
{
    public interface IQrcodeGenerator
    {
        public Byte[] GernerateQR(string text);
    }
}
