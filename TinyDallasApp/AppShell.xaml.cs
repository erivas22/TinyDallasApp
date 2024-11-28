namespace TinyDallasApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    private async void OnAccountClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Account", "Account page not implemented.", "OK");
    }

    private async void OnContactClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Contact", "Contact page not implemented.", "OK");
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Log out", "You have been logged out.", "OK");
    }
}
