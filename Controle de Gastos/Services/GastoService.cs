using Controle_de_Gastos.Exceptions.CustomExceptions;
using Controle_de_Gastos.model;
using Controle_de_Gastos.Repo;
using Controle_de_Gastos.Repositories;

namespace Controle_de_Gastos.Services;

public class GastoService
{
    private readonly IGastoRepository _repo;

    public GastoService(IGastoRepository gastoRepository)
    {
        _repo = gastoRepository;
    }

    public async Task<Gasto> AdicionarGasto (Gasto gasto)
    {
        int mes = gasto.Data.Month;
        var mesFormat = $"{mes:D1}";

        int ano = gasto.Data.Year;
        
        string MesAno = mesFormat + "/" + ano;
        gasto.Mes = MesAno;

        List<string> mensagensDeErro = ValidaGasto.ValidarGasto(gasto);

        if (mensagensDeErro.Count > 0)
        {
            throw new ErroDeValidacaoDeGastoException(mensagensDeErro);
        }

        await _repo.AdicionarGasto(gasto);
        return gasto;
    }

}
