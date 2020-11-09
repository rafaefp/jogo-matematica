using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMatematica
{
    class Program
    {
        static void Main(string[] args)
        {            
            int quantidadeQuestoes;            
            int respostasCorretas = 0;
            
            QuestoesMatematica questoes = new QuestoesMatematica();
            
            Console.WriteLine("JOGO MATEMÁTICA**************************\n");
            Console.Write("Digite a quantidade de questões: ");
            
            Random random = new Random();
            
            quantidadeQuestoes = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantidadeQuestoes; i++)
            {                
                bool acertou;
                
                int sorteio = random.Next(4);                
                
                try
                {                    
                    switch (sorteio)
                    {
                        case 0:
                            acertou = questoes.GerarQuestaoAdicao();
                            if (acertou)
                            {
                                respostasCorretas++;
                            }
                            break;
                        case 1:
                            acertou = questoes.GerarQuestaoSubtracao();
                            if (acertou)
                            {
                                respostasCorretas++;
                            }
                            break;
                        case 2:
                            acertou = questoes.GerarQuestaoMultiplicacao();
                            if (acertou)
                            {
                                respostasCorretas++;
                            }
                            break;
                        case 3:
                            acertou = questoes.GerarQuestaoDivisao();
                            if (acertou)
                            {
                                respostasCorretas++;
                            }
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Não é possível realizar divisão por 0.");
                }               
            }            
            Console.WriteLine("\nVocê acertou a resposta em " + respostasCorretas + " de " + quantidadeQuestoes + " questões.");
            Console.WriteLine("******************************************");            
            Console.ReadLine();
        }
    }
}
