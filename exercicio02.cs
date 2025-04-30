namespace Exercicios
{
    public class TabuadaCompleta
    {
        public static void ExibirTabuada()
        {
            Console.WriteLine("Insira um número: ");
            int escolha = int.Parse(Console.ReadLine());
            
            // enquanto o contador for menor que 11, ele vai rodar
            for(int i; i < 11; i++)
            {
                resultado = escolha * i;
                Console.WriteLine($"{escolha} x {i} = {resultado}");
            }
        }
    }
}