using JobSearch.Services;
using JobSearch.Views;

namespace JobSearch;

public partial class App : Application
{
	public App(INavigationService navigationService)
	{
		InitializeComponent();

		MainPage = new NavigationPage();
		navigationService.NavigateToFirstPage();
	}
}

