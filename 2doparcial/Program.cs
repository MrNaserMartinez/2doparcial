using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJEMPLOS DE LA POO

//------------------EJEMPLO 1  Abstracción----------------// 

//public abstract class FormaGeometrica
//{
//    public abstract double CalcularArea();
//    public abstract double CalcularPerimetro();
//}

//public class Rectangulo : FormaGeometrica
//{
//    public double Base { get; set; }
//    public double Altura { get; set; }
//    public Rectangulo(double b, double h)
//    {
//        Base = b;
//        Altura = h;
//    }
//    public override double CalcularArea()
//    {
//        return Base * Altura;
//    }
//    public override double CalcularPerimetro()
//    {
//        return 2 * (Base + Altura);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Rectangulo rectangulo = new Rectangulo(4,6);
//        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
//        Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
//    }
//}

//------------------EJEMPLO 2 HERENCIA----------------// 
//public class Vehiculo
//{
//    public string Marca { get; set; }
//    public string Modelo { get; set; }
//    public Vehiculo(string marca, string modelo)
//    {
//        Marca = marca;
//        Modelo = modelo;
//    }
//    public virtual void MostrarInformacion()
//    {
//        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
//    }
//}
//public class Automovil : Vehiculo
//{
//    // Constructor
//    public Automovil(string marca, string modelo) : base(marca, modelo) { }

//    public override void MostrarInformacion()
//    {
//        base.MostrarInformacion();
//        Console.WriteLine("Tipo: Automóvil");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Automovil automovil = new Automovil("Toyota", "Corolla");
//        automovil.MostrarInformacion();
//    }
//}


//------------------EJEMPLO 3 Polimormismo----------------// 
//public class Vehiculo
//{
//    public string Marca { get; set; }
//    public string Modelo { get; set; }

//    // Constructor
//    public Vehiculo(string marca, string modelo)
//    {
//        Marca = marca;
//        Modelo = modelo;
//    }

//    public virtual void MostrarInformacion()
//    {
//        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
//    }
//}

//// Clase derivada Automovil que hereda de Vehiculo
//public class Automovil : Vehiculo
//{
//    // Constructor
//    public Automovil(string marca, string modelo) : base(marca, modelo) { }

//    // Sobrescritura del método MostrarInformacion para Automovil
//    public override void MostrarInformacion()
//    {
//        base.MostrarInformacion();
//        Console.WriteLine("Tipo: Automóvil");
//    }
//}

//// Clase derivada Camion que hereda de Vehiculo
//public class Camion : Vehiculo
//{
//    // Constructor
//    public Camion(string marca, string modelo) : base(marca, modelo) { }

//    // Sobrescritura del método MostrarInformacion para Camion
//    public override void MostrarInformacion()
//    {
//        base.MostrarInformacion();
//        Console.WriteLine("Tipo: Camión");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una lista de vehículos
//        List<Vehiculo> vehiculos = new List<Vehiculo>();
//        vehiculos.Add(new Automovil("Toyota", "Corolla"));
//        vehiculos.Add(new Camion("HINO", "El rey de los caminos"));

//        // Mostrar información de todos los vehículos
//        foreach (Vehiculo vehiculo in vehiculos)
//        {
//            vehiculo.MostrarInformacion();
//        }
//    }
//}

//------------------EJEMPLO 4 Encapsulamiento----------------// 
//public class Vehiculo
//{
//    public string Marca { get; protected  set; }

//    // Constructor
//    public Vehiculo(string marca)
//    {
//        this.Marca = marca;
//    }
//    public void MostrarMarca()
//    {
//        Console.WriteLine($"Marca del vehículo: {Marca}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehiculo vehiculo = new Vehiculo("Toyota");
//        vehiculo.MostrarMarca();
//    }
//}

//-----------------EJEMPLO UTILIZANDO LAS 4--------------------//
//class Program
//{
//    // Método principal Main
//    static void Main(string[] args)
//    {
//        // Crear una instancia de PlayStation llamada ps5
//        PlayStation ps5 = new PlayStation("PS5");

//        // Llamar al método Iniciar de la instancia ps5
//        ps5.Iniciar();

//        // Llamar al método Apagar de la instancia ps5
//        ps5.Apagar();
//    }
//}

//-----------------EJEMPLO 6 INTERFACES--------------------//
//public interface IVehiculo
//{
//    void Acelerar();
//    void Frenar();
//    void MostrarInformacion();
//}
//public class Automovil : IVehiculo
//{
//    public void Acelerar()
//    {
//        Console.WriteLine("Automóvil acelerando...");
//    }

//    public void Frenar()
//    {
//        Console.WriteLine("Automóvil frenando...");
//    }

//    public void MostrarInformacion()
//    {
//        Console.WriteLine("Este es un automóvil.");
//    }
//}

//public class Camion : IVehiculo
//{
//    public void Acelerar()
//    {
//        Console.WriteLine("Camión acelerando...");
//    }

//    public void Frenar()
//    {
//        Console.WriteLine("Camión frenando...");
//    }

//    public void MostrarInformacion()
//    {
//        Console.WriteLine("Este es un camión.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear instancias de Automovil y Camion
//        IVehiculo vehiculo1 = new Automovil();
//        IVehiculo vehiculo2 = new Camion();

//        // Llamar a los métodos de la interfaz
//        vehiculo1.Acelerar();
//        vehiculo1.MostrarInformacion();

//        vehiculo2.Frenar();
//        vehiculo2.Acelerar();
//        vehiculo2.MostrarInformacion();
//    }
//}

//-----------------EJEMPLO 7 DELEGADOS--------------------//

//public delegate void DelegadoOperacion(int a, int b);

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Método que suma dos números
//        void Sumar(int a, int b)
//        {
//            Console.WriteLine($"La suma de {a} y {b} es: {a + b}");
//        }

//        // Método que resta dos números
//        void Restar(int a, int b)
//        {
//            Console.WriteLine($"La resta de {a} y {b} es: {a - b}");
//        }

//        // Creación de instancias del delegado y asignación de métodos
//        DelegadoOperacion operacion1 = Sumar;
//        DelegadoOperacion operacion2 = Restar;

//        // Invocación de los métodos a través del delegado
//        operacion1(5, 3); // Sumar
//        operacion2(5, 3); // Restar
//    }
//}

//-----------------EJEMPLO 8 Indexadores--------------------//
//public class Coleccion
//{
//    private string[] elementos = new string[5];
//    //ESTE ES EL INDEXADOR
//    public string this[int i]
//    {
//        get { return elementos[i]; }
//        set { elementos[i] = value; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear instancia de Coleccion
//        Coleccion coleccion = new Coleccion();

//        // Asignar valores a través del indexador
//        coleccion[0] = "Elemento 1";
//        coleccion[1] = "Elemento 2";
//        coleccion[2] = "HOLA MUNDO CLASICO XD";
//        coleccion[3] = "Elemento 4";
//        coleccion[4] = "Elemento 5";

//        // Acceder a los valores a través del indexador
//        Console.WriteLine(coleccion[0]);
//        Console.WriteLine(coleccion[1]);
//        Console.WriteLine(coleccion[2]);
//        Console.WriteLine(coleccion[3]);
//        Console.WriteLine(coleccion[4]);
//    }
//}

//-----------------EJEMPLO 9 PROPIEDADES--------------------//

//public class Persona
//{
//    private string nombre;
//    private int edad;

//    // Propiedad Nombre con validación
//    public string Nombre
//    {
//        get { return nombre; }
//        set
//        {
//            if (!string.IsNullOrEmpty(value))
//                nombre = value;
//            else
//                Console.WriteLine("Nombre inválido.");
//        }
//    }

//    // Propiedad Edad con validación
//    public int Edad
//    {
//        get { return edad; }
//        set
//        {
//            if (value >= 0 && value <= 90)
//                edad = value;
//            else
//                Console.WriteLine("Edad inválida.");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear instancia de Persona
//        Persona persona = new Persona();

//        // Asignar valores a las propiedades
//        persona.Nombre = "Naser";
//        persona.Edad = 18;

//        // Acceder a los valores de las propiedades
//        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
//    }
//}

//-----------------EJEMPLO 10 EVENTOS--------------------//

public delegate void TiempoAlcanzadoEventHandler(object sender, EventArgs e);

public class Temporizador
{
    public event TiempoAlcanzadoEventHandler TiempoAlcanzado;
    public void Iniciar(int segundos)
    {
        Console.WriteLine("Temporizador iniciado.");
        System.Threading.Thread.Sleep(segundos * 1000);

        // Cuando el tiempo alcanza el límite, disparamos el evento TiempoAlcanzado
        OnTiempoAlcanzado();
    }

    // Método para disparar el evento TiempoAlcanzado
    protected virtual void OnTiempoAlcanzado()
    {
        TiempoAlcanzado?.Invoke(this, EventArgs.Empty);
    }
}

// Clase principal Program
class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Temporizador
        Temporizador temporizador = new Temporizador();

        // Suscribirse al evento TiempoAlcanzado
        temporizador.TiempoAlcanzado += Temporizador_TiempoAlcanzado;

        temporizador.Iniciar(3);
    }

    // Método que maneja el evento TiempoAlcanzado
    static void Temporizador_TiempoAlcanzado(object sender, EventArgs e)
    {
        Console.WriteLine("¡El tiempo ha sido alcanzado!");
    }
}