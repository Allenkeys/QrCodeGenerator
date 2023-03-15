using System;
using QrCodeGenerator.BLL.Interfaces;
using QRCoder;

namespace QrCodeGenerator.BLL.Implementations
{
    public class QrcodeGenerator : IQrcodeGenerator
    {
        public byte[] GenerateQR(string text)
        {
            byte[] code = Array.Empty<byte>();
            if (!string.IsNullOrEmpty(text))
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData data = qRCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                BitmapByteQRCode bitmapQRCode = new BitmapByteQRCode(data);
                code = bitmapQRCode.GetGraphic(20);
            }
            return code;
        }
    }
}
