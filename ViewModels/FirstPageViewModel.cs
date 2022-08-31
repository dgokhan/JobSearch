using System;
using System.Collections.ObjectModel;
using JobSearch.Models;
using JobSearch.Services;

namespace JobSearch.ViewModels
{
    public class FirstPageViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public FirstPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public Command NavigateCommand
            => new Command(async () => await navigationService.NavigateToMainPage());
    }
}

