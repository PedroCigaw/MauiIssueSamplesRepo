namespace CurrentCultureSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = CultureDataService.Instance;
	}

    protected override void OnAppearing()
    {
        MainThread.BeginInvokeOnMainThread(() => { this.lstX.ItemsSource = new CultureData().Cultures; });
        base.OnAppearing();
    }


}

