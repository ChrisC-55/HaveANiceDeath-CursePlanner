using HaveANiceDeath.Data;
using HaveANiceDeath.Models;
using Microsoft.AspNetCore.Mvc;

namespace HaveANiceDeath.Controllers
{
    public class CurseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CurseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddCurse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCurse(AddCurseViewModel model)
        {
            Curse newCurse = new Curse();

            newCurse.CurseName = model.CurseName;
            newCurse.CurseColor = model.CurseColor;
            newCurse.CurseRarity = model.CurseRarity;
            newCurse.CurseType = model.CurseType;
            newCurse.CurseDescription = model.CurseDescription;
            newCurse.CurseRank = model.CurseRank;
            newCurse.CurseImagePath = SaveFile(model.CurseImage);

            _context.Curses.Add(newCurse);
            await _context.SaveChangesAsync();

            return RedirectToAction("AddCurse");
        }

        private string SaveFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return null;
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var fileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Path.Combine("uploads", fileName);
        }
    }
}
