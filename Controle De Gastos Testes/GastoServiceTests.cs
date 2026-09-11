using Controle_de_Gastos.model;
using Controle_de_Gastos.Repositories;
using Controle_de_Gastos.Services;
using Moq;

namespace Controle_De_Gastos_Testes;

public class GastoServiceTests
{
    [Fact]
    public async Task AdicionaGasto_ComDataValida_DeveGerarMesAnoCorreto()
    {
        // arrange
        var mockRepo = new Mock<IGastoRepository>();
        IGastoRepository repository = mockRepo.Object;
        var service = new GastoService(repository);

        Gasto gasto = new();
        gasto.Data = new DateOnly(2026, 12, 25);

        // act
        var result = await service.AdicionarGasto(gasto);

        // assert
        Assert.Equal("12/2026", gasto.Mes);
    }
}