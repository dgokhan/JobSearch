using System;
using System.Collections.ObjectModel; 
using JobSearch.Models;
using JobSearch.Services;
using JobSearch.Views;

namespace JobSearch.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public ObservableCollection<FeaturedJobs> FeaturedJobs { get; set; }
        public ObservableCollection<RecomendedJobs> RecomendedJobs { get; set; }

        public Command NavigateToDetailPageCommand => 
            new Command<RecomendedJobs>(async (param) => await ExecuteNavigateToDetailPageCommand(param));
         
        public MainPageViewModel(INavigationService navigationService)
        {  
            FeaturedJobs = new ObservableCollection<FeaturedJobs>();
            RecomendedJobs = new ObservableCollection<RecomendedJobs>();

            GetFeaturedJobs();
            GetRecomendedJobs();
            this.navigationService = navigationService;
        } 

        void GetFeaturedJobs()
        {
            FeaturedJobs = new ObservableCollection<FeaturedJobs>(DataService.GetFeaturedJobs());
        }
        
        void GetRecomendedJobs()
        {
            RecomendedJobs = new ObservableCollection<RecomendedJobs>(DataService.GetRecomendedJobs());
        }

        private async Task ExecuteNavigateToDetailPageCommand(RecomendedJobs m)
        {
            await navigationService.NavigateToDetailPage(m);
        }
    }
}

