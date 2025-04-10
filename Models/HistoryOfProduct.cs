using PR4_Partners_CRUD.Models;
using System;
using System.Collections.Generic;

namespace PR4_Partners_CRUD;

public partial class HistoryOfProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public DateOnly DateOfSale { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
