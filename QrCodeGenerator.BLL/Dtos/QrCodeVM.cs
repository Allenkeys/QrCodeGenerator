using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeGenerator.BLL.Dtos
{
    public class QrCodeVM
    {
        public byte[] Code { get; set; }
        public string Title { get; set; }
    }
}
