using ExploreCalifornia.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly BlogDataContext db;

        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = db.MonthlySpecials.ToArray();
            return View(specials);
        }
    }
}