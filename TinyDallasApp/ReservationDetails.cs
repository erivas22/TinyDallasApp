namespace TinyDallasApp;

public class ReservationDetails
{
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
    public string SpecialRequests { get; set; }
    public string Location { get; set; }
    //public List<string> SelectedFoodItems { get; set; } = new();
    public List<string> SelectedFoodItems { get; set; } = new List<string>();
    public string PhoneNumber { get; set; }
    
}
