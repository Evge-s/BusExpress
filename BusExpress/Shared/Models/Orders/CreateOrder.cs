using System.ComponentModel.DataAnnotations;

namespace BusExpress.Shared.Models.Orders;

public class CreateOrder
{
    [Required]
    public string City { get; set; }

    [Required]
    public int Postcode { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string ReceiverNameSurname { get; set; }

    [Required]
    public string Number { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public int Weight { get; set; }

    [Required]
    public DateTime Date { get; set; }
}
