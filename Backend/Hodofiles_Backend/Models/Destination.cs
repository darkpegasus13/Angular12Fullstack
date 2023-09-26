using System;
using System.Collections.Generic;

namespace CatalogService.Models;

public partial class Destination
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
