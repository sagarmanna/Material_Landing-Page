using Microsoft.AspNetCore.Mvc;
using MaterialLandingApp.Models;

namespace MaterialLandingApp.ViewComponents
{
    public class DashboardBoxesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<DashboardBoxModel> boxes)
        {
            return View(boxes);
        }
    }
}