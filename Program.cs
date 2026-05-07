using System

class Program
{
    static void Main()
    {

        Console.Write("Digite o primeiro numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        int resultado = numero1 + numero2;

        Console.WriteLine("Resultado: " + resultado);
    }
}