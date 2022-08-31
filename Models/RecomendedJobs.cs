using System;
namespace JobSearch.Models
{
    public class RecomendedJobs
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string CompanyAddress { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Salary { get; set; }
        public Color BackgroundColor { get; set; }
        public List<WantedFeatures> FeatureInfo { get; set; }
    }
}

