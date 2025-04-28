using System;
using System.Linq;

namespace Exercicios
{
    public class PasswordValidation
    {
        Console.WriteLine("Insira uma senha: ");
        string password = console.ReadLine();
    
        if(
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit) &&
            password.Any(char => !char.IsLetterOrDigit(char)))
        {
            Console.WriteLine("Senha válida!");
        } 
        else
        {
            Console.WriteLine("Senha inválida.");
        }
            
    }
}