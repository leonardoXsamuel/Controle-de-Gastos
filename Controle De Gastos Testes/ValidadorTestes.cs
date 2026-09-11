using Controle_de_Gastos;
using Controle_de_Gastos.Exceptions.CustomExceptions;
using Controle_de_Gastos.model;
using Controle_de_Gastos.Repositories;
using Controle_de_Gastos.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_De_Gastos_Testes;

public class ValidadorTestes
{
    [Fact]
    public void Validador_Insere_Na_Lista_Varias_Exceções()
    {
        // arrange
        Gasto gasto = new();

        gasto.Data = DateOnly.FromDateTime(DateTime.Today.AddDays(3));
        gasto.Valor = decimal.Zero;

        // act
        List<string> listaErros = [];
        listaErros.AddRange(ValidaGasto.ValidarGasto(gasto));

        // assert
        Assert.Equal(2, listaErros.Count);
    }

    [Fact]
    // dois erros acumulam, service retorna Exception, Repository não é chamado.
    public void Adicionar_Gasto_Lanca_ErroDeValidacaoDeGastoException_Repo_Nao_Eh_Chamado()
    {
        // arrange
        Gasto gasto = new();

        gasto.Data = DateOnly.FromDateTime(DateTime.Today.AddDays(3));
        gasto.Valor = decimal.Zero;
        
        // moqs
        var mockRepo = new Mock<IGastoRepository>();
        IGastoRepository repository = mockRepo.Object;
        var service = new GastoService(repository);

        // act + assert
        Assert.Throws<ErroDeValidacaoDeGastoException>(() => ValidaGasto.ValidarGasto(gasto));
        var gastoAdc = service.AdicionarGasto(gasto);

        mockRepo.Verify();
    }

    [Fact]
    public void X()
    {

    }



}
