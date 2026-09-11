using System.ComponentModel;

namespace Controle_de_Gastos.Models.ENUMs;

public enum FormaDePagamentoGasto
{
    Crédito,
    Pix,
    Débito,
    [Description("Boleto/Transferência")]
    BoletoOuTransferência,
    Dinheiro
}