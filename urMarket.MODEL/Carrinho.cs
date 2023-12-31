﻿using System;
using System.Collections.Generic;

namespace urMarket.MODEL;

public partial class Carrinho
{
    public int Id { get; set; }

    public int IdProd { get; set; }

    public int IdUsuario { get; set; }

    public decimal Total { get; set; }

    public int Quantidade { get; set; }

    //public virtual Produto IdProdNavigation { get; set; } = null!;
    public virtual ICollection<Produto> IdProdNavigation { get; set; } = new List<Produto>();

    //public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<Usuario> IdUsuarioNavigation { get; set; } = new List<Usuario>();
}
