namespace TinyDallasApp;

public partial class PhoneNumberPage : ContentPage
{
    private readonly ReservationDetails _reservationDetails;

    public PhoneNumberPage(ReservationDetails reservationDetails)
    {
        InitializeComponent();
        _reservationDetails = reservationDetails;
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        _reservationDetails.PhoneNumber = PhoneNumberEntry.Text;

        await Navigation.PushAsync(new FinalConfirmationPage(_reservationDetails));
    }
}
