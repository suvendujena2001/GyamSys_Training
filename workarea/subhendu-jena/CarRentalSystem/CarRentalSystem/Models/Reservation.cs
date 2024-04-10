using System;
using System.Collections.Generic;

namespace CarRentalSystem.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? UserId { get; set; }

    public int? VehicleId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual User? User { get; set; }

    public virtual Vehicle? Vehicle { get; set; }
}
