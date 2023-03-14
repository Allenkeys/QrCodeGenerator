using System;

namespace QrCodeGenerator.BLL.Interfaces
{
    public interface IQrcodeGenerator
    {
        public byte[] GenerateQR(string text);
    }
}
