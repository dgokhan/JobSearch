using JobSearch.Models;
using JobSearch.ViewModels;

namespace JobSearch.Views;

public partial class DetailPage : ContentPage
{ 
	public DetailPage(DetailPageViewModel m)
	{
		InitializeComponent();
        
		BindingContext = m;
	} 
}


