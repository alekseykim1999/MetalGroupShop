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
using MusicShop.Interfaces;
using MusicShop.WorkClasses;

namespace MusicShop.Controllers
{
    public class MusicConverterController : Controller
    {
      
        NotesViewModel converted_notes = new NotesViewModel();
        public MusicConverterController()
        {
          
        }

        public IActionResult LoadTrack() 
        {
            return View();
        }

        [HttpPost]
        public ViewResult ConvertTrack(IFormCollection form)
        {
            IConvertable sound_notes = new SoundConverter();
            //var stream = System.IO.File.OpenRead(form["_file"].ToString());
            converted_notes.notes = sound_notes.ConvertSound().ToString();
            return View(converted_notes);
        
        }

    }
}
