namespace Exercicios
{
    public class Palindromo
    {
        public static void VerificaPalindromo()
        {
            Console.WriteLine("Insira uma frase para verificar se é palíndromo: ");
            string frase = Console.ReadLine();

            // removendo os espaços
            fraseSemEspacos = frase.replace(" ", "");

            // convertendo pra minúsculas
            fraseLimpa = fraseSemEspacos.ToLower();

            // aqui a gente quebra a frase em um array de caracteres
            char[] caracteres = fraseLimpa.ToCharArray();

            // aqui a gente inverte o array gerado (trás pra frente)
            Array.Reverse(caracteres);

            // aqui a gente instancia a variavel fraseInvertida com o array gerado acima
            string fraseInvertida = new string(caracteres);

            // compara se a frase original é igual à frase invertida construída, se for retorna o positivo e se não, retorna o negativo.
            if (fraseLimpa == fraseInvertida)
            {
                Console.WriteLine("É palíndromo.");
            }
            else
            {
                Console.WriteLine("Não é palíndromo.");
            }
        }
    }
}