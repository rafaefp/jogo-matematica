using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMatematica
{
    public class QuestoesMatematica
    {
        private Random random = new Random();

        public bool GerarQuestaoAdicao()
        {            
            bool acertou;                     
            int numero1 = random.Next(51);            
            int numero2 = random.Next(51);
            
            Console.Write(numero1 + " + " + numero2 + " = ");
            
            int resposta = Int32.Parse(Console.ReadLine());            
            int resultado = numero1 + numero2;
            
            if (resultado == resposta)
            {
                acertou = true;
            }
            else
            {
                acertou = false;
            }            
            return acertou;
        }
        public bool GerarQuestaoSubtracao()
        {
            bool acertou;
            int numero1 = random.Next(51);
            int numero2 = random.Next(51);

            Console.Write(numero1 + " - " + numero2 + " = ");

            int resposta = Int32.Parse(Console.ReadLine());

            int resultado = numero1 - numero2;

            if (resultado == resposta)
            {
                acertou = true;
            }
            else
            {
                acertou = false;
            }
            return acertou;
        }
        public bool GerarQuestaoMultiplicacao()
        {
            bool acertou;
            int numero1 = random.Next(11);
            int numero2 = random.Next(11);

            Console.Write(numero1 + " x " + numero2 + " = ");

            int resposta = Int32.Parse(Console.ReadLine());

            int resultado = numero1 * numero2;

            if (resultado == resposta)
            {
                acertou = true;
            }
            else
            {
                acertou = false;
            }
            return acertou;
        }
        public bool GerarQuestaoDivisao()
        {
            bool acertou;
            int numero1 = random.Next(11);
            int numero2 = random.Next(11);
            
            Console.Write(numero1 + " / " + numero2 + " = ");

            int resposta = Int32.Parse(Console.ReadLine());
            
            int resultado = numero1 / numero2;
                                    
            if (resultado == resposta)
            {
                acertou = true;
            }
            else
            {
                acertou = false;
            }            
            return acertou;            
        }
    }
}
