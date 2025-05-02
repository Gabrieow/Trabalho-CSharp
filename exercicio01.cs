using System;
using System.Linq;

namespace Exercicios
{
    public class PasswordValidation
    {
        public static void ValidaSenha()
        {
            // solicita a senha
            Console.WriteLine("Insira uma senha: ");

            // lê a senha
            string password = Console.ReadLine();
        
        
            // verifica se a senha contém: 8 ou mais caracteres, pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial
            // e imprime se a senha é válida ou inválida
            if(
                password.Length >= 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit) &&
                password.Any(c => !char.IsLetterOrDigit(c)))
            {
                Console.WriteLine("Senha válida!");
            } 
            else
            {
                Console.WriteLine("Senha inválida.");
            }
        }
    }
}