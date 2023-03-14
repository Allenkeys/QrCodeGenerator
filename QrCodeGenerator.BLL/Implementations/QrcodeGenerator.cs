using QrCodeGenerator.BLL.Interfaces;

namespace QrCodeGenerator.BLL.Implementations
{
    public interface QrcodeGenerator : IQrcodeGenerator
    {
        byte[] GernerateQR(string text)
        {
            byte[] data = new byte[text.Length];
            return data;
        }
    }
}