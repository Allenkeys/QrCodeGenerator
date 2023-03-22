using Microsoft.AspNetCore.Mvc;
using QrCodeGenerator.BLL.Interfaces;
using QrCodeGenerator.BLL.ViewModels;

namespace QrCodeGenerator.MVC.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class QrCodeController : Controller
    {
        private readonly IQrcodeGenerator _qrcodeGenerator;

        public QrCodeController(IQrcodeGenerator qrcodeGenerator)
        {
            _qrcodeGenerator = qrcodeGenerator;
        }

        
        public IActionResult Index(object obj)
        {   
            if (obj == null)
            {
                return View(obj);
            }
            return View(new QrGeneratorVM());
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                BadRequest();
            }
            if (ModelState.IsValid)
            {
                byte[] CodeAsByte = _qrcodeGenerator.GenerateQR(text);
                string CodeAsImage = $"data:image/png;base64,{Convert.ToBase64String(CodeAsByte)}";
                QrGeneratorVM model = new QrGeneratorVM();
                if (!string.IsNullOrEmpty(text))
                {
                    model.QrImageUrl = CodeAsImage;
                    //TempData["code"] = CodeAsImage;


                    return View(model);
                }
            }


            return View();

        }


    }
}
