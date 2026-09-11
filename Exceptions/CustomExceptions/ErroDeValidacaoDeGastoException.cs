namespace Controle_de_Gastos.Exceptions.CustomExceptions;

public class ErroDeValidacaoDeGastoException : Exception
{
    public ErroDeValidacaoDeGastoException(List<string> msgs)
    {
        msgsDeErro = msgs;
    }

    public List<string> msgsDeErro { get; set; }
}
