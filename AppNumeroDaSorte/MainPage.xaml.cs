namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckyNumbers(Object sender, EventArgs e)
	{
        AppName.IsVisible = false;
		ContainerLuckyNumbers.IsVisible = true;
	}
}
