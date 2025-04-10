using System;
using System.Collections.Generic;

namespace PR4_Partners_CRUD.Models;

public partial class UnitsOfMeasurement
{
    public short Id { get; set; }

    public string UnitOfMeasurement { get; set; } = null!;

    public virtual ICollection<HistoriOfSupplier> HistoriOfSuppliers { get; set; } = new List<HistoriOfSupplier>();
}
