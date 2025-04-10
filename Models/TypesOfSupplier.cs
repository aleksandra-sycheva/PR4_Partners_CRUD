using System;
using System.Collections.Generic;

namespace PR4_Partners_CRUD.Models;

public partial class TypesOfSupplier
{
    public short Id { get; set; }

    public string TypeOfSupplier { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
