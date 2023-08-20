using System;
using System.Collections.Generic;

namespace _01_Weekly_Task.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
