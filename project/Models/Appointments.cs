namespace project.Models;

public class Appointment
{
    public int Id { get; set; }

    public string ClientName { get; set; } = "";
    
    public Alpaca AlpacaChosen { get; set; }
    
    public DateTime AppointmentStart { get; set; }
    
    public DateTime AppointmentEnd { get; set; }
}