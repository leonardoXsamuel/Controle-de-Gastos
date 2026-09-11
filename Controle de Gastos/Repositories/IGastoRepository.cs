using Controle_de_Gastos.model;

namespace Controle_de_Gastos.Repositories;

public interface IGastoRepository
{
    public Task<Gasto> AdicionarGasto(Gasto gasto);
}
