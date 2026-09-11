namespace Controle_de_Gastos.Exceptions.CustomExceptions;

public class ValorDeEnumInexistenteException : Exception
{
    public ValorDeEnumInexistenteException() : base() { }
    public ValorDeEnumInexistenteException(string message) : base(message) { }
}
