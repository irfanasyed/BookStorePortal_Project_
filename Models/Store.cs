﻿using System;
using System.Collections.Generic;

namespace BookStorePortal_Project_.Models;

public partial class Store
{
    public int StorId { get; set; }

    public string? StorName { get; set; }

    public string? StorAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
