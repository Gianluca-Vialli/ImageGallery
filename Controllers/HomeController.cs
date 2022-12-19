﻿using System.Linq;
using ImageGallery.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ImageGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (GalleryContext dataBase = new GalleryContext())
            {
                var gallery = dataBase.Galerias.Include(gallery => gallery.Images).AsNoTracking().ToList();
                return View(gallery);
            }
        }


    }
}
