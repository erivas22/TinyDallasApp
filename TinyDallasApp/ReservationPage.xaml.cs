using System;

namespace TinyDallasApp;

public partial class ReservationPage : ContentPage
{
    public ReservationPage()
    {
        InitializeComponent();
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        int adults = int.TryParse(AdultsEntry.Text, out var a) ? a : 0;
        int children = int.TryParse(ChildrenEntry.Text, out var c) ? c : 0;
        string phoneNumber = PhoneNumberEntry.Text; // Assuming you have an Entry named phoneNumberEntry

        var reservationDetails = new ReservationDetails
        {
            Date = DatePicker.Date,
            Time = TimePicker.Time,
            Adults = adults,
            Children = children,
            SpecialRequests = SpecialRequestsEditor.Text,
            Location = LocationEntry.Text,
            PhoneNumber = phoneNumber,     // Set the phone number here

        };

        await Navigation.PushAsync(new ConfirmationPage(reservationDetails));
    }
}