//namespace TinyDallasApp;

//public partial class FinalConfirmationPage : ContentPage
//{
//    private readonly ReservationDetails _reservationDetails;

//    public FinalConfirmationPage(ReservationDetails reservationDetails)
//    {
//        InitializeComponent();
//        _reservationDetails = reservationDetails;

//        //SummaryLabel.Text = $"Date: {_reservationDetails.Date:MMMM dd, yyyy}\n" +
//        //                    $"Time: {_reservationDetails.Time}\n" +
//        //                    $"Adults: {_reservationDetails.Adults}\n" +
//        //                    $"Children: {_reservationDetails.Children}\n" +
//        //                    $"Phone: {_reservationDetails.PhoneNumber}\n" +
//        //                    $"Special Requests: {_reservationDetails.SpecialRequests}\n" +
//        //                    $"Location: {_reservationDetails.Location}\n" +
//        //                    $"Selected Food Items: {string.Join(", ",_reservationDetails.SelectedFoodItems)}";
//        // Assign values to the new Labels
//        DateLabel.Text = _reservationDetails.Date.ToString("MMMM dd, yyyy");
//        TimeLabel.Text = _reservationDetails.Time.ToString();
//        AdultsLabel.Text = _reservationDetails.Adults.ToString();
//        ChildrenLabel.Text = _reservationDetails.Children.ToString();
//        SpecialRequestsLabel.Text = _reservationDetails.SpecialRequests ?? "None"; // Handle null
//        LocationLabel.Text = _reservationDetails.Location ?? "Not Provided"; // Handle null
//        PhoneNumberLabel.Text = string.IsNullOrWhiteSpace(_reservationDetails.PhoneNumber) ? "Not Provided" : _reservationDetails.PhoneNumber;


//    }

//    private async void OnConfirmClicked(object sender, EventArgs e)
//    {
//        // Here you can add code to save the reservation to a database or send a confirmation email

//        await Navigation.PushAsync(new ReservationSuccessPage());
//    }
//}

// FinalConfirmationPage.xaml.cs

namespace TinyDallasApp;

public partial class FinalConfirmationPage : ContentPage
{
    private readonly ReservationDetails _reservationDetails;

    public FinalConfirmationPage(ReservationDetails reservationDetails)
    {
        InitializeComponent();
        _reservationDetails = reservationDetails;

        // Assign values to the Labels
        DateLabel.Text = _reservationDetails.Date.ToString("MMMM dd, yyyy");
        TimeLabel.Text = _reservationDetails.Time.ToString(@"hh\:mm");
        AdultsLabel.Text = _reservationDetails.Adults.ToString();
        ChildrenLabel.Text = _reservationDetails.Children.ToString();
        SpecialRequestsLabel.Text = string.IsNullOrWhiteSpace(_reservationDetails.SpecialRequests) ? "None" : _reservationDetails.SpecialRequests;
        LocationLabel.Text = string.IsNullOrWhiteSpace(_reservationDetails.Location) ? "Not Provided" : _reservationDetails.Location;
        PhoneNumberLabel.Text = string.IsNullOrWhiteSpace(_reservationDetails.PhoneNumber) ? "Not Provided" : _reservationDetails.PhoneNumber;

        // Display selected food items
        if (_reservationDetails.SelectedFoodItems != null && _reservationDetails.SelectedFoodItems.Count > 0)
        {
            SelectedFoodItemsLabel.Text = string.Join(", ", _reservationDetails.SelectedFoodItems);
        }
        else
        {
            SelectedFoodItemsLabel.Text = "No food items selected";
        }
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        // Handle confirmation logic here

        await Navigation.PushAsync(new ReservationSuccessPage());
    }
}

