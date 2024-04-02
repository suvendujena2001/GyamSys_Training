using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class Report
{
    public int Id { get; set; }

    public DateTime? TimeStarted { get; set; }

    public DateTime? TimeFinished { get; set; }

    public int? VehicleId { get; set; }

    public string? JobsCompleted { get; set; }

    public int MechanicId { get; set; }

    public int? AppointmentId { get; set; }

    public int? CustomerId { get; set; }

    public string? GeneralComments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual Appointment? Appointment { get; set; }

    public virtual Mechanic Mechanic { get; set; } = null!;

    public virtual Vehicle? Vehicle { get; set; }
}
