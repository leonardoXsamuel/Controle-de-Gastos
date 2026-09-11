using Controle_de_Gastos.Exceptions.CustomExceptions;
using Controle_de_Gastos.model;
using Controle_de_Gastos.Models.ENUMs;

namespace Controle_de_Gastos;

public class ValidaGasto
{
    public static List<string> ValidarGasto (Gasto gasto)
    {
        List<Exception> exceptions = new List<Exception>();

        if (gasto.Data > DateOnly.FromDateTime(DateTime.Today))
        {
            var ex = new DataExcedidaException("A data não pode ser maior do que hoje.");
            exceptions.Add(ex);
        }

        if (gasto.Valor <= 0)
        {
            var ex = new ValorErradoException("O valor do gasto não pode ser menor ou igual à 0.");
            exceptions.Add(ex);
        }

        if (!(Enum.IsDefined(typeof(CategoriaGasto), gasto.Categoria))) {
            var ex = new ValorDeEnumInexistenteException($"Categoria {gasto.Categoria} nãoi é permitido.");
            exceptions.Add(ex);
        }
        if (!(Enum.IsDefined(typeof(FormaDePagamentoGasto), gasto.FormaDePagamento)))
        {
            var ex = new ValorDeEnumInexistenteException($"Forma de Pagamento {gasto.FormaDePagamento} não é permitido.");
            exceptions.Add(ex);
        }

        List<string> mensagensDeErro = [];

        foreach (var item in exceptions)
        {
            mensagensDeErro.Add(item.Message);
        }

        return mensagensDeErro;

    }
}
