using JobSearch.ViewModels;

namespace JobSearch.Views;

public partial class FirstPage : ContentPage
{

	public FirstPage(FirstPageViewModel m)
	{
		InitializeComponent();

        BindingContext = m;
    } 
}


