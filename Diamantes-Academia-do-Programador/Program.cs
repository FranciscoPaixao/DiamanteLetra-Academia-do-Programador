using System;

namespace Diamantes_Academia_do_Programador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            while (true)
            {
                Console.Write("Informe uma letra (com exceção do A): ");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra == 'A' || letra == 'a')
                {
                    Console.WriteLine("Com exceção do A!");
                }
                else
                {
                    break;
                }
            }
            int meioDiamante;
            char exibirLetra;
            if (Char.IsUpper(letra)){
                meioDiamante = letra - 64;
                exibirLetra = 'A';
            }
            else
            {
                meioDiamante = letra - 96;
                exibirLetra = 'a';
            }
            int numeroLinhas = (meioDiamante * 2) - 1;
            int letraComecoFim = 0;
            for (int i = 0; i < meioDiamante; i++)
            {
                letraComecoFim++;
                Console.WriteLine("");
                for (int j = 0; j < numeroLinhas; j++)
                {
                    if (j == meioDiamante + letraComecoFim - 2 || j == meioDiamante - letraComecoFim)
                    {
                        Console.Write(exibirLetra);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                exibirLetra++;
            }
            letraComecoFim = meioDiamante;
            exibirLetra--;
            for (int i = meioDiamante; i < numeroLinhas; i++)
            {
                letraComecoFim--;
                exibirLetra--;
                Console.WriteLine("");
                for (int j = 0; j < numeroLinhas; j++)
                {
                    if (j == meioDiamante + letraComecoFim - 2 || j == meioDiamante - letraComecoFim)
                    {
                        Console.Write(exibirLetra);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            while (true) ;
        }

    }
}