using System;
using System.Collections.Generic;

namespace CatalogService.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
