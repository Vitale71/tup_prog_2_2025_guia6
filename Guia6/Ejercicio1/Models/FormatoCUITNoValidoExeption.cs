namespace Ejercicio1.Models;

public class FormatoCUITNoValidoExeption : ApplicationException
{
    public FormatoCUITNoValidoExeption (): base("cuit no valido") { }
    public FormatoCUITNoValidoExeption (string message) : base (message) { }
    public FormatoCUITNoValidoExeption (string mensage, Exception inner) { }
}
