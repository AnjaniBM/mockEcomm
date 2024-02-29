namespace mockEcomm.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
	await Navigation.PushAsync(new SampleSecond());	
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductsPage());
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdminLoginPage());
    }
}