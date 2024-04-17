using System;
using System.Collections.Generic;

namespace BlogAPI.Models;

public partial class Blog
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
