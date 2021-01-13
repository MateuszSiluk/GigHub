using GigHub.Data;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}
