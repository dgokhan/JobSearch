using JobSearch.Models;

namespace JobSearch.ViewModels
{
    public class DetailPageViewModel : ViewModelBase
    {
        private RecomendedJobs recomendedJobs { get; set; }
        public RecomendedJobs RecomendedJobs 
        {
            get => recomendedJobs; 
            set
            {
                recomendedJobs = value;
                RaisePropertyChanged();
            }
        }

        public DetailPageViewModel()
        {
            RecomendedJobs = new RecomendedJobs();
        }
        
        public override Task OnNavigatingTo(object? parameter)
        {
            RecomendedJobs = parameter as RecomendedJobs;
            return base.OnNavigatingTo(parameter);
        }
    }
}

