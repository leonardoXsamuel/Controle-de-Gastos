namespace Controle_de_Gastos.Exceptions.CustomExceptions;

public class ValorErradoException : Exception
{
    public ValorErradoException() : base() { }
    public ValorErradoException(string message) : base(message) { }
}
