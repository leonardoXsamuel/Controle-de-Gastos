namespace Controle_de_Gastos.Exceptions.CustomExceptions;

public class DataExcedidaException : Exception
{
    public DataExcedidaException() : base() { }
    public DataExcedidaException(string message) : base(message) { }
}
