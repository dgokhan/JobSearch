using System;
using System.Collections.ObjectModel;
using JobSearch.Models;

namespace JobSearch.Services
{
    public class DataService
    {
        public static ObservableCollection<FeaturedJobs> GetFeaturedJobs()
        {
            return new ObservableCollection<FeaturedJobs>()
            {
                new FeaturedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Microsoft",
                       JobTitle = "UI/UX Designer",
                        Salary = "345.00",
                         Image = "microsoft.png",
                          BackgroundColor = Color.FromHex("#a41b33"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                },
                new FeaturedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Californaia, USA",
                      CompanyName = "Google",
                       JobTitle = "UI/UX Designer",
                        Salary = "345.00",
                         Image = "google.png",
                          BackgroundColor = Color.FromHex("#541BB2"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("6A1AEB"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("6A1AEB"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("6A1AEB"),
                                }
                            }
                },
                new FeaturedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Microsoft",
                       JobTitle = "UI/UX Designer",
                        Salary = "345.00",
                         Image = "microsoft.png",
                          BackgroundColor = Color.FromHex("#a41b33"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                }
            };
        }

        public static ObservableCollection<RecomendedJobs> GetRecomendedJobs()
        {
            return new ObservableCollection<RecomendedJobs>()
            {
                new RecomendedJobs
                {
                    Id = Guid.NewGuid(), 
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Facebook",
                       JobTitle = "Product Designer",
                        Salary = "215.00",
                         Image = "facebook.png",
                          BackgroundColor = Color.FromHex("#B4CCFF"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                },
                new RecomendedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Youtube",
                       JobTitle = "Lead Graphic Designer",
                        Salary = "525.00",
                         Image = "youtube.png",
                          BackgroundColor = Color.FromHex("#FFA6A6"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                },
                new RecomendedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Twitter",
                       JobTitle = "Developer",
                        Salary = "215.00",
                         Image = "twitter.png",
                          BackgroundColor = Color.FromHex("#C1ECFF"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                },
                new RecomendedJobs
                {
                    Id = Guid.NewGuid(),
                     CompanyAddress = "Washington, USA",
                      CompanyName = "Youtube",
                       JobTitle = "Mobile Developer",
                        Salary = "215.00",
                         Image = "youtube.png",
                          BackgroundColor = Color.FromHex("#FFA6A6"),
                            FeatureInfo = new List<WantedFeatures>
                            {
                                new WantedFeatures
                                {
                                     Value = "Design",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Full-Time",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }, new WantedFeatures
                                {
                                     Value = "Senior",
                                     BackgroundColor = Color.FromHex("bc394f"),
                                }
                            }
                }
            };

        }
    }
}

