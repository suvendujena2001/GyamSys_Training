using System;
using System.Collections.Generic;

namespace ProjectApi.Models;

public partial class User
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public int Id { get; set; }

    public virtual Mechanic Id1 { get; set; } = null!;

    public virtual Customer IdNavigation { get; set; } = null!;
}
