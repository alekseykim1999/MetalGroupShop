using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.FileModels;
using Ocr;
using Tesseract;
using System.Drawing;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class TextSearcherController : Controller
    {
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        ScanViewModel scanned = new ScanViewModel();
        public TextSearcherController(ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult SearchPage() 
        {
            return View();
        }

        [HttpPost]
        public ViewResult ScanPicture(IFormCollection form)
        {
            var service = new TesseractService(@"C:\Program Files\Tesseract-OCR", "eng", @"C:\Program Files\Tesseract-OCR\tessdata");
            var stream = System.IO.File.OpenRead(form["_file"].ToString());
            scanned.ScannedText = service.GetText(stream);
            return View(scanned);
        
        }

    }
}
