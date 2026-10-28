using Imc.Models;

Console.WriteLine("Aplicacion que calcula el IMC de una persona");
Console.WriteLine();

decimal peso = ReadDecimal("Ingrese su peso en kilogramos: ");
decimal estatura = ReadDecimal("Ingrese la estatura en metros: ");

string entrada;
bool entradadeValida;

decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
var estadoNutricional = CalculadoraImc.EstadoNutricional(imc);

Console.WriteLine($"El indice de masa corporal de la persona es: {imc:F4}");
Console.WriteLine($"El estado nutricional de la persona es: {estadoNutricional}");

static decimal ReadDecimal(string indicacion)
{
    string entrada;
    bool entradadeValida;
    decimal valor;
    do
    {
        Console.Write(indicacion);
        entrada = Console.ReadLine();
        entradadeValida = decimal.TryParse(entrada, out valor);
        if (!entradadeValida)
        {
            Console.WriteLine("Error la entradad debe de ser numerica.");
        }
    } while (!entradadeValida);
    return valor;
}