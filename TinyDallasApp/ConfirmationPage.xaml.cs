namespace TinyDallasApp;

public partial class ConfirmationPage : ContentPage
{
    private readonly ReservationDetails _reservationDetails;

    public ConfirmationPage(ReservationDetails reservationDetails)
    {
        InitializeComponent();
        _reservationDetails = reservationDetails;

        // Assign values to the new Labels
        DateLabel.Text = _reservationDetails.Date.ToString("MMMM dd, yyyy");
        TimeLabel.Text = _reservationDetails.Time.ToString();
        AdultsLabel.Text = _reservationDetails.Adults.ToString();
        ChildrenLabel.Text = _reservationDetails.Children.ToString();
        SpecialRequestsLabel.Text = _reservationDetails.SpecialRequests ?? "None"; // Handle null
        LocationLabel.Text = _reservationDetails.Location ?? "Not Provided"; // Handle null
        PhoneNumberLabel.Text = string.IsNullOrWhiteSpace(_reservationDetails.PhoneNumber) ? "Not Provided" : _reservationDetails.PhoneNumber;
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FoodSelectionPage(_reservationDetails));
    }
}
