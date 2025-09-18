namespace Ejercicio1.Models;

public class Persona : IComparable
{
    protected string nombre {  get; set; }
    public string Nombre { get { return nombre; } }

    public Persona (string nombre)
    {
        this.nombre = nombre;
    }

    public virtual string Descubrir()
    {
        return $"Persona \n\t Nombre: {Nombre}";
    }

    public int CompareTo(object obj)
    {
        Persona nueva = obj as Persona;
        if (nueva != null) {
            return this.nombre.CompareTo(nueva.Nombre);
        }
        return -1;
    }
}
