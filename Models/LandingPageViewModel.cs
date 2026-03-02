using System.Collections.Generic;

namespace MaterialLandingApp.Models
{
    public class LandingPageViewModel
    {
        public List<MenuItem> MenuItems { get; set; } = new();
        public List<DashboardBoxModel> DashboardBoxes { get; set; } = new();
        public List<FeatureModel> Features { get; set; } = new();
        public List<PricingPlanModel> PricingPlans { get; set; } = new();
        public List<TeamMemberModel> TeamMembers { get; set; } = new();
        public List<FaqModel> FAQs { get; set; } = new();
        public List<TableRowModel> TableRows { get; set; } = new();
        public List<ReviewModel> Reviews { get; set; } = new();
    }
}