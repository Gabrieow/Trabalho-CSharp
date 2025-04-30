namespace Exercicios
{
    public class CalculoIMC
    {
        public void CalcularIMC()
        {
            Console.WriteLine("Insira o peso(kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura(m): ");
            double altura = double.Parse(Console.ReadLine());

            double calculoIMC = peso / (altura * altura);

            // condicionais pra verificar o imc
            if(calculoIMC < 18.5) { Console.WriteLine("Abaixo do peso."); }

            else if(18.5 >= calculoIMC && calculoIMC <= 24.9) { Console.WriteLine("Peso Normal."); }

            else if(25 >= calculoIMC && calculoIMC <= 29.9) { Console.WriteLine("Sobrepeso."); }

            else if(calculoIMC >= 30) { Console.WriteLine("Obesidade."); }
        }
    }
}