namespace MaterialLandingApp.Models
{
    public class LandingPageViewModel
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<DashboardBoxModel> DashboardBoxes { get; set; }
        public List<FeatureModel> Features { get; set; }
        public List<PricingPlanModel> PricingPlans { get; set; }
        public List<TeamMemberModel> TeamMembers { get; set; }
        public List<FaqModel> FAQs { get; set; }
        public List<TableRowModel> TableRows { get; set; }
        public List<ReviewModel> Reviews { get; set; }
    }
}