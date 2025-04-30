namespace Exercicios
{
    public class Fatorial
    {
        public static void CalculoFatorial()
        {
            Console.WriteLine("Insira um número positivo: ");
            int escolha = int.Parse(Console.ReadLine());

            // tratamento de erro pra caso o usuário insira um número errado
            if (escolha < 0)
            {
                Console.WriteLine("Número inválido. Insira um número positivo: ");
                escolha = int.Parse(Console.ReadLine());
            } 
            else
            {
                int i = escolha;
                int resultado = 1;

                // enquanto i for maior que 1, vai rodar o código
                while(i > 1)
                {
                    // utilizando *= pra multiplicar e guardar o valor multiplicado na variável resultado
                    resultado *= i;
                    i--;
                }
            }

            // exibe o resultado
            Console.WriteLine($"O fatorial de {escolha} é: {resultado}");
        }
    }
}