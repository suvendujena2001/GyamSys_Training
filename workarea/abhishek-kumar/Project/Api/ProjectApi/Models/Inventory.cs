using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class Inventory
{
    public string? ProductName { get; set; }

    public int Id { get; set; }

    public int? Quantity { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }
}
