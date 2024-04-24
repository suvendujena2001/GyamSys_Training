using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class Appointment
{
    public decimal Id { get; set; }

    public int AppointmentId { get; set; }

    public int? CustomerId { get; set; }

    public int? MechanicId { get; set; }

    public DateOnly? Date { get; set; }

    public int? VehicleId { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Mechanic? Mechanic { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual Vehicle? Vehicle { get; set; }
}
