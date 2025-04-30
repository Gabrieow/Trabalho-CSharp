namespace Exercicios
{
    public class JogoAdivinhacao
    {
        public void Jogo()
        {
            // usando a biblioteca Random do C# pra gerar um número aleatório de 1 a 100
            Random aleatorio = new Random();
            int numeroCerto = aleatorio.Next(1, 101);
            int palpite = 0, tentativas = 0;

            // enquanto palpite for diferente do número certo, ele vai executar o bloco
            while(palpite != numeroCerto)
            {
                // lê o palpite e acrescenta as tentativas
                Console.WriteLine("Insira um palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite == numeroCerto)
                {
                    Console.WriteLine($"Parabéns, você acertou!\nNúmero de tentativas {tentativas}");
                }
                else
                {
                    Console.WriteLine("Você errou!");
                    // condicional extra pra "guiar" o jogador
                    if (palpite > numeroCerto)
                    {
                        Console.WriteLine("O Número informado é maior do que o número certo!");
                    }
                    else
                    {
                        Console.WriteLine("O Número informado é menor do que o número certo!");
                    }
                }
            }

        }
    }
}