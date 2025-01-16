using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Adivinhacao
    {
        public static void Executar() 
        {
            int palpite=0, tentativasRestantes=5 , tentativas = 0;
            Random random = new Random();
            bool numEncontrado=false;
            int numSecreto=random.Next(1,11);

            Console.WriteLine("Digite o palpite: ");
            int.TryParse(Console.ReadLine(), out palpite);

            while (tentativasRestantes>0 && !numEncontrado) 
            {
                
                tentativas++;
                tentativasRestantes--;


                if (palpite == numSecreto) 
                { 
                    numEncontrado = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns você achou o numero");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Tentativas feitas: {0}", tentativas);

                }else if (palpite != numSecreto)
                {
                    Console.WriteLine("Digite outro palpilte: ");
                    int.TryParse(Console.ReadLine(), out palpite);
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);    
                }
            }
            
            


        }
    }
}
