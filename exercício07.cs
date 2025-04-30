namespace Exercicios
{
    public class Pares
    {
        public void VerificaPares()
        {
            // inicializando a lista numeros
            List<int> numeros = new List<int>();
            int soma = 0;

            // alimentando a lista números com 10 números
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Insira um número: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            // para cada elemento na lista número, ele verifica se é par, se for, ele adiciona o valor na variável "soma"
            foreach (var numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    soma += numero;
                }
            }

            Console.WriteLine($"A soma dos pares é: {soma}");

        }
    }
}