using System;
using System.Collections.Generic;

namespace CarRentalSystem.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? ReservationId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Reservation? Reservation { get; set; }
}
