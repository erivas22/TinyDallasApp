namespace TinyDallasApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnMakeReservationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReservationPage());
    }
}

