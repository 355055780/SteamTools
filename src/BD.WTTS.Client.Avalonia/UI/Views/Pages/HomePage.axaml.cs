using BD.WTTS.Client.Resources;

namespace BD.WTTS.UI.Views.Pages;

public partial class HomePage : ReactiveUserControl<HomePageViewModel>
{
    public HomePage()
    {
        InitializeComponent();
        this.SetViewModel<HomePageViewModel>();

        //Subtitle = "11111111111111111111111111111";
        //Description = "2222222222222222222222222222222";
        //ContentDescription = "This is a description";
    }
}