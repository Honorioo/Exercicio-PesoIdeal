using System;

namespace Exercicio_PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
                 double pesoMasculino, pesoFeminino, Altura;
                 string Masculino = "M" , Feminino = "F" , Sexo;

          Console.Write("Digite sua altura (metro) ...: ");
          Altura = Convert.ToDouble(Console.ReadLine());

          Console.Write("[M]asculino / [F]eminino...:");
          Sexo = Console.ReadLine();

                pesoMasculino = (Altura * 72.7) - 58.0;

                pesoFeminino = (Altura * 62.1) - 44.7;

          if (Sexo == Masculino)

         { 
              Console.Write($"Seu peso ideal é {pesoMasculino:N1}");
         }
          
         else if (Sexo == Feminino) 

          {
              Console.Write($"Seu peso ideal é {pesoFeminino:N1}");
          }
        }
    }
}
