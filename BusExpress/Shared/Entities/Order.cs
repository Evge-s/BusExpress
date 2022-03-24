namespace BusExpress.Shared.Entities;

public class Order
{
    public int Id { get; set; }
    public string City { get; set; }
    public int Postcode { get; set; }
    public string Address { get; set; }
    public string NameSurname { get; set; }
    public string Number { get; set; }
    public int Quantity { get; set; }
    public int Weight { get; set; }
    public DateTime Date { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; }
}
