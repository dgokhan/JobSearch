using JobSearch.ViewModels;

namespace JobSearch.Views;

public partial class MainPage : ContentPage
{

    public MainPage(MainPageViewModel m)
    {
        InitializeComponent();

        BindingContext = m;
    }
}


