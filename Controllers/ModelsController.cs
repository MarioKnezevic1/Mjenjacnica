using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mjenjačnica.Data;
using Mjenjačnica.Models;
using System.Diagnostics;
using System.Linq;

namespace Mjenjačnica.Controllers
{
    public class ModelsController : Controller
    {
        private readonly MjContext _context;

        public ModelsController(MjContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Calculate(string Ku, string Ki, string IznosU, Evidencija evidencija)
        {
            var m = await _context.Tecaj.Where(t => t.KonvertirajU == Ku && t.KonvertirajIz == Ki).FirstOrDefaultAsync();
            double iznos = double.Parse(IznosU) * m.Tecaj;
            evidencija.IznosU = iznos;
            evidencija.IznosIz = double.Parse(IznosU);
            evidencija.Tecaj = m.Tecaj;
            evidencija.KonvertirajU = Ku;
            evidencija.KonvertirajIz = Ki;
            evidencija.Vrijeme = DateTime.Now;
            _context.Add(evidencija);
            await _context.SaveChangesAsync();
            return View("Rezultat", evidencija);

        }
    }
}