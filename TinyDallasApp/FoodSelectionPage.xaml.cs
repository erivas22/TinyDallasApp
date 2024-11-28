//namespace TinyDallasApp;

//public partial class FoodSelectionPage : ContentPage
//{
//    private readonly ReservationDetails _reservationDetails;

//    public FoodSelectionPage(ReservationDetails reservationDetails)
//    {
//        InitializeComponent();
//        _reservationDetails = reservationDetails;
//    }

//    private async void OnContinueClicked(object sender, EventArgs e)
//    {
//        // Retrieve selected food items
//        var selectedItems = FoodCollectionView.SelectedItems.Cast<string>().ToList();
//        _reservationDetails.SelectedFoodItems = selectedItems;

//        // Navigate to the ConfirmationPage with updated reservation details
//        await Navigation.PushAsync(new FinalConfirmationPage(_reservationDetails));
//    }
//}
// FoodSelectionPage.xaml.cs

namespace TinyDallasApp;

public partial class FoodSelectionPage : ContentPage
{
    private readonly ReservationDetails _reservationDetails;
    private List<FoodItem> _foodItems;

    public FoodSelectionPage(ReservationDetails reservationDetails)
    {
        InitializeComponent();
        _reservationDetails = reservationDetails;

        // Initialize your food items
        _foodItems = GetFoodItems();

        // Set the ItemsSource for the CollectionView
        FoodCollectionView.ItemsSource = _foodItems;
    }

    private List<FoodItem> GetFoodItems()
    {
        // Replace with your actual data source
        return new List<FoodItem>
        {
            new FoodItem { Name = "Mini Pancakes" },
            new FoodItem { Name = "Elotes" },
            new FoodItem { Name = "Fruit" },
            // Add more items as needed
        };
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        // Collect selected items
        var selectedItems = _foodItems.Where(item => item.IsSelected).ToList();

        // Update the ReservationDetails
        _reservationDetails.SelectedFoodItems = selectedItems.Select(item => item.Name).ToList();

        // Navigate to FinalConfirmationPage
        await Navigation.PushAsync(new FinalConfirmationPage(_reservationDetails));
    }
}

