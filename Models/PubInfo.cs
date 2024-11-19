using System;
using System.Collections.Generic;

namespace BookStorePortal_Project_.Models;

public partial class PubInfo
{
    public int? PubId { get; set; }

    public string? Logo { get; set; }

    public string? PrInfo { get; set; }

    public virtual Publisher? Pub { get; set; }
}
