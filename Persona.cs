public class Persona {

    public string nombre { get; set; }
    public int edad { get; set; }
    public string direccion { get; set; }
    public float peso { get; set; }
    public float altura { get; set; }

    public void MostrarDatos() {
        Console.WriteLine("Nombre: {0}", nombre,"\nEdad: {0}", edad, "\nDirección: {0}", direccion);
    }

    public void CalcularIMC() {
        float imc = this.peso / (this.altura * this.altura);
        Console.WriteLine("IMC: {0}", imc);
    }

    public void ActualizarDatos() {
        // Obtiene los datos del usuario
        Console.WriteLine("Introduce tu nombre:");
        this.nombre = Console.ReadLine();
        Console.WriteLine("Introduce tu edad:");
        this.edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce tu dirección:");
        this.direccion = Console.ReadLine();
    }
}
