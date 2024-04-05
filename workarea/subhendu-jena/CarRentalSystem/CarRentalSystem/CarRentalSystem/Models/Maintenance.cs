using System;
using System.Collections.Generic;

namespace CarRentalSystem.Models;

public partial class Maintenance
{
    public int MaintenanceId { get; set; }

    public int? VehicleId { get; set; }

    public DateTime? MaintenanceDate { get; set; }

    public string? Description { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Vehicle? Vehicle { get; set; }
}
