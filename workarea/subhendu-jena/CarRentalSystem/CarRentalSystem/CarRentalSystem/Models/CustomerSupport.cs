using System;
using System.Collections.Generic;

namespace CarRentalSystem.Models;

public partial class CustomerSupport
{
    public int SupportId { get; set; }

    public int? UserId { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Channel { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual User? User { get; set; }
}
