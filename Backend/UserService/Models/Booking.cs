using System;
using System.Collections.Generic;

namespace CatalogService.Models;

public partial class Booking
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? DestinationId { get; set; }

    public decimal? Fare { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Destination? Destination { get; set; }
}
