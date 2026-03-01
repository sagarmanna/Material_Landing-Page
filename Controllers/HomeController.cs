using Microsoft.AspNetCore.Mvc;
using MaterialLandingApp.Models;

namespace MaterialLandingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new LandingPageViewModel
            {
                MenuItems = new List<MenuItem>
                {
                    new MenuItem { Name = "Home", Url = "#" },
                    new MenuItem { Name = "Features", Url = "#features" },
                    new MenuItem { Name = "Pricing", Url = "#pricing" },
                    new MenuItem { Name = "Team", Url = "#team" },
                    new MenuItem { Name = "FAQ", Url = "#faq" },
                    new MenuItem { Name = "Contact", Url = "#contact" }
                },

                Features = new List<FeatureModel>
                {
                    new FeatureModel { Title="Fast Performance", Description="Optimized UI performance", Icon="bx bx-bolt" },
                    new FeatureModel { Title="Responsive Design", Description="Mobile friendly layout", Icon="bx bx-mobile" },
                    new FeatureModel { Title="Secure System", Description="Best security practices", Icon="bx bx-lock" }
                },
PricingPlans = new List<PricingPlanModel>
{
    new PricingPlanModel { Name="Basic", Price=0 },
    new PricingPlanModel { Name="Standard", Price=9 },
    new PricingPlanModel { Name="Enterprise", Price=19 }
},

                TeamMembers = new List<TeamMemberModel>
                {
                    new TeamMemberModel { Name="John Smith", Role="CEO", Image="team-member-1.png" },
                    new TeamMemberModel { Name="Sara Lee", Role="Designer", Image="team-member-2.png" },
                    new TeamMemberModel { Name="David Kim", Role="Developer", Image="team-member-3.png" }
                },

                FAQs = new List<FaqModel>
                {
                    new FaqModel { Question="Is this template free?", Answer="Yes for demo purposes." },
                    new FaqModel { Question="Can I customize it?", Answer="Yes it is fully customizable." }
                },

                TableRows = new List<TableRowModel>
                {
                    new TableRowModel { Name="John Doe", Email="john@gmail.com", Status="Active" },
                    new TableRowModel { Name="Jane Smith", Email="jane@gmail.com", Status="Pending" }
                },

                Reviews = new List<ReviewModel>
                {
                    new ReviewModel { Customer="Eugenia", Comment="Amazing dashboard template.", Company="Tech Corp" }
                }
            };

            return View(model);
        }
    }
}