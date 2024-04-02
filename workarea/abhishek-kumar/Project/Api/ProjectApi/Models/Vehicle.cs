using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public string? Colour { get; set; }

    public string? NumberPlate { get; set; }

    public string? FuelType { get; set; }

    public string? TransmissionType { get; set; }

    public string? Cylinders { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
