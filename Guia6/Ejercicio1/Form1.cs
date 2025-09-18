using System.Configuration;
using Ejercicio1.Models;
namespace Ejercicio1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    List<Persona> persona = new List<Persona>();
    private void btnAgregar_Click(object sender, EventArgs e)
    {
        Form2 ventana = new Form2();

        while (ventana.ShowDialog() == DialogResult.OK)
        {
            string nombre = ventana.tbNombre.Text;
            Persona p = null;
            ventana.tbNombre.Enabled = false;
            ventana.tbCuit.Enabled = false;
            if (ventana.radioButton1.Checked)
            {
                p = new Persona(nombre);
            }
            else if (ventana.radioButton2.Checked)
            {
                string cuit = ventana.tbCuit.Text;

                p = new PersonaJuridica(nombre, cuit);
            }
            if (p != null)
            {
                persona.Add(p);
            }
            else 
            { 
                MessageBox.Show("debe elegir el tipo");
                ventana.ShowDialog();
            }
        }
        Actualizar();
    }
    protected void Actualizar()
    {
        foreach (Persona p in persona)
        {
            listBox1.Items.Add(p.Descubrir());
        }
    }
}
