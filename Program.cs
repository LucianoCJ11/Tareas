// Interfaz Mensaje
public interface IMensaje
{
    string ObtenerContenido();
}

// Clase Mensaje
public class Mensaje : IMensaje
{
    private string _contenido;

    public Mensaje(string contenido)
    {
        _contenido = contenido;
    }

    public string ObtenerContenido()
    {
        return _contenido;
    }
}

// Main
public abstract class DecoradorMensaje : IMensaje
{
    protected IMensaje _mensaje;

    public DecoradorMensaje(IMensaje mensaje)
    {
        _mensaje = mensaje;
    }

    public abstract string ObtenerContenido();
}

// Mensaje Encriptado
public class EncriptarMensaje : DecoradorMensaje
{
    public EncriptarMensaje(IMensaje mensaje) : base(mensaje)
    {
    }

    public override string ObtenerContenido()
    {
        // Encriptacion de mensaje ejp
        return $"[Encriptado]{_mensaje.ObtenerContenido()}";
    }
}

// Mensaje Comprimido
public class ComprimirMensaje : DecoradorMensaje
{
    public ComprimirMensaje(IMensaje mensaje) : base(mensaje)
    {
    }

    public override string ObtenerContenido()
    {
        // Imprimir mensaje comprimido
        return $"[Comprimido]{_mensaje.ObtenerContenido()}";
    }
}

// Firmado del mensaje 
public class FirmarMensaje : DecoradorMensaje
{
    public FirmarMensaje(IMensaje mensaje) : base(mensaje)
    {
    }

    public override string ObtenerContenido()
    {
        // Imprimir firma
        return $"{_mensaje.ObtenerContenido()} [Contrato Firmado]";
    }
}

// Implimentacion
public class Program
{
    public static void Main(string[] args)
    {
        // Mensaje en pantalla
        IMensaje mensaje = new Mensaje("SIUUUU");

        // Mensaje
        IMensaje mensajeEncriptado = new EncriptarMensaje(mensaje);
        Console.WriteLine(mensajeEncriptado.ObtenerContenido());

        // Mensaje
        IMensaje mensajeComprimido = new ComprimirMensaje(mensajeEncriptado);
        Console.WriteLine(mensajeComprimido.ObtenerContenido());

        // Firma del contrato
        IMensaje mensajeFirmado = new FirmarMensaje(mensajeComprimido);
        Console.WriteLine(mensajeFirmado.ObtenerContenido());

 
    }
}
 
