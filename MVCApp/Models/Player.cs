using System;
using System.Collections.Generic;

namespace MVCApp.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string PlayerName { get; set; } = null!;

    public DateTime Dob { get; set; }

    public int Matches { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int JerseyNumber { get; set; }
}
