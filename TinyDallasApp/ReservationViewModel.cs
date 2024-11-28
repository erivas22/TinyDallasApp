using System.Collections.ObjectModel;

namespace TinyDallasApp
{
    public class ReservationViewModel
    {
        public ObservableCollection<string> SelectedFoodItems { get; set; } = new ObservableCollection<string>();
    }
}
