﻿using System;
using System.Collections.Generic;

namespace PR4_Partners_CRUD.Models;

public partial class TypesOfPartner
{
    public short Id { get; set; }

    public string TypeOfPartner { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
