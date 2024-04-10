using System;
using System.Collections.Generic;

namespace CarRentalSystem.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? Color { get; set; }

    public decimal? Mileage { get; set; }

    public decimal? RentalRatePerHour { get; set; }

    public decimal? RentalRatePerDay { get; set; }

    public decimal? RentalRatePerWeek { get; set; }

    public string? AvailabilityStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
