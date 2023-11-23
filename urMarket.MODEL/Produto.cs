using System;
using System.Collections.Generic;

namespace urMarket.MODEL;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public byte[] Foto { get; set; } = null!;

    public decimal Valor { get; set; }

    public string CaminhoFoto { get; set; }

    public int IdCat { get; set; }

    public virtual ICollection<Carrinho> Carrinhos { get; set; } = new List<Carrinho>();

    public virtual Categoria IdCatNavigation { get; set; } = null!;
}
