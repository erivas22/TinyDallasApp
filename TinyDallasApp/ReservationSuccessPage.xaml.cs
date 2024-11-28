namespace TinyDallasApp;

public partial class ReservationSuccessPage : ContentPage
{
    public ReservationSuccessPage()
    {
        InitializeComponent();
    }

    private async void OnReturnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
