using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayVenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] venda = new double[5];
            double[] comissao = new double[5];

            for (int i = 0; i <=4;  i++)
            {
                Console.WriteLine("Qual o nome do vendedor");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Qual a venda do vendedor");
                venda[i] = double.Parse(Console.ReadLine());
                Console.Clear();
                if (venda[i] <= 20.000)
                {
                    comissao[i] = venda[i] * 0.05;
                }else if (venda[i] <= 40.000)
                {
                    comissao[i] = venda[i] * 0.06;
                }
                else
                {
                    comissao[i] = venda[i] * 0.07;
                }
            }

            for (int j =0; j<=4; j++)
            {
                Console.WriteLine("O vendedor " + nome[j]+" atingiu " + venda[j].ToString("C") + "e ganhou " + comissao[j].ToString("C")+ " de comissão");
            }
            Console.ReadKey();
        }
    }
}
