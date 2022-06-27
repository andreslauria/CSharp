Cliente cliente1 = new Cliente("Andres",2216945189, "San martin 234", "anda@gmail.com", true);


Console.WriteLine("Nombre: "+cliente1.nombre+" Telefono: "+cliente1.telefono+" Direccion: " + cliente1.direccion);
Console.WriteLine("Email: " + cliente1.email);
Console.WriteLine("Es cliente nuevo: " + cliente1.esNuevo);



/// <summary>
/// Estructura de Datos personales del cliente
/// </summary>

public struct Cliente
{
    public string nombre { get; }
    public double telefono { get; }
    public string direccion { get; }
    public string email { get; }
    public bool esNuevo { get; }

    public Cliente(string cNombre, double cTelefono, string cDireccion, string cEmail, bool cEsNuevo)
    {
        this.nombre = cNombre;
        this.telefono = cTelefono;
        this.direccion = cDireccion;
        this.email = cEmail;
        this.esNuevo = cEsNuevo;
    }

    
}






