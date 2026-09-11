    using Controle_de_Gastos.Context;
    using Controle_de_Gastos.model;
    using Controle_de_Gastos.Repositories;

    namespace Controle_de_Gastos.Repo;

    public class GastoRepository : IGastoRepository
    {
        private readonly GastoDbContext _dbContext;

        public GastoRepository(GastoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Gasto> AdicionarGasto(Gasto gasto)
        {
            await _dbContext.AddAsync(gasto);
            await _dbContext.SaveChangesAsync();

            return gasto;
        }

    }
