namespace Ejercicio1.Models
{
    public class PersonaJuridica : Persona
    {
        private string cuit;
        
        public PersonaJuridica(string nombre, string cuit) :base(nombre)
        {
            this.cuit = cuit;
        }

        public override string Descubrir()
        {
            return $"Persona juridica \n\t {base.Descubrir()}, cuil: {cuit}";
        }
    }
}
