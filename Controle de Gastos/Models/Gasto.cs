using Controle_de_Gastos.Models.ENUMs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Controle_de_Gastos.model;

public class Gasto
{
    public long Id { get; set; }

    [NotNull]
    public string Mes { get; set; }

    [NotNull]
    public DateOnly Data { get; set; }

    [NotNull]
    public CategoriaGasto Categoria { get; set; }

    [NotNull]
    public decimal Valor { get; set; }

    [NotNull]
    public FormaDePagamentoGasto FormaDePagamento { get; set; }

    [StringLength(255)]
    public string? Descrição { get; set; }
}
