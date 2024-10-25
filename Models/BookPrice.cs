using System;
using System.Collections.Generic;

namespace Book_Price_Backend.Models;

public partial class BookPrice
{
    public string Partner { get; set; } = null!;

    public string? ClientName { get; set; }

    public string? Policynumber { get; set; }

    public string? ProductProvider { get; set; }

    public decimal? AdjustedRevenue { get; set; }

    public decimal? AdjustedAssetValue { get; set; }

    public decimal? BookPrice1 { get; set; }

    public DateOnly? StatementDate { get; set; }
}
