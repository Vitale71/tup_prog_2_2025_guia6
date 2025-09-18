namespace Ejercicio1.Models;

internal class FormatoNombreNoValidoExeption : ApplicationException
{
    public FormatoNombreNoValidoExeption() { }
    public FormatoNombreNoValidoExeption(string message) : base(message) { }
}
