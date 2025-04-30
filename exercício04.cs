namespace Exercicios
{
    public class MenuTemperaturas
    {
        
        public void Menu()
        {
            Console.WriteLine("CONVERSOR DE TEMPERATURAS");
            Console.WriteLine("Opções:\n1 - CELSIUS -> FAHRENHEIT\n2 - FAHRENHEIT -> CELSIUS\n3 - SAIR");

            string opcao = Console.ReadLine();

            // switch case chamando os métodos construídos na classe "Funções"
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Você escolheu - CELSIUS -> FAHRENHEIT");
                    Funcoes.ToFahrenheit();
                    break;
                
                case "2":
                    Console.WriteLine("Você escolheu - FAHRENHEIT -> CELSIUS");
                    Funcoes.ToCelsius();
                    break;
                
                case "3":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    // classe "Funções" com 2 métodos de conversão
    public class Funcoes
    {
        // métodos estáticos porque são ligados à classe e não à um objeto específico
        public static void ToFahrenheit()
        {
            Console.WriteLine("Insira o valor em Cº para converter: ");
            double celsius = double.Parse(Console.ReadLine());

            double resultado = (celsius * 9/5) + 32;

            Console.WriteLine($"O valor de {celsius}ºC para Fahrenheit é: {resultado}ºF.");
        }

        public static void ToCelsius()
        {
            Console.WriteLine("Insira o valor em Fº para converter: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double resultado = (fahrenheit - 32) * 5/9;

            Console.WriteLine($"O valor de {fahrenheit}ºF para Celsius é: {resultado}ºC.");
        }
    }
}