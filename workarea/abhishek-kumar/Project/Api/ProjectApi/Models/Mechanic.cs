using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class Mechanic
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? PhoneNumber { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual User? User { get; set; }
}
