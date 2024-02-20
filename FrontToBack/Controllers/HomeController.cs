using Esigned.Core.Entities;
using FrontToBack.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        readonly EsignedDbContext _esignedDbContext;

        public HomeController(EsignedDbContext esignedDbContext)
        {
            this._esignedDbContext = esignedDbContext;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders =
                await _esignedDbContext.Sliders.Where(x => !x.IsDeleted)
                .AsNoTracking()
                .ToListAsync();

            return View(sliders);
        }
    }
}
