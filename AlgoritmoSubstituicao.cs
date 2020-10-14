/******************************************
*Universidade Paulista - UNIP Alphaville
*Sistema de Informação - 6°Semestre
*
*Sistemas Operacionais Abertos
*
*Aluno: Michele Brandão Morais
*Matrícula: N286DB9
*
*Data de entrega: 14/10/2020
*******************************************/
using System;
using System.Collections.Generic;

namespace AlgoritmoSubstituicao{
    class Program{
        static void Main(string[] args) {
            
            //Variáveis
            int[] pags = new int[10] { 9, 2, 3, 5, 4, 7, 7, 5, 3, 1 };
            int[] elementoFifo = new int[3];
            int faltas = 0;
            int repeticaoRit = 0;
            //
            
            //Impressão de início
            Console.WriteLine("----  Algoritmo de Substituição de Páginas - FIFO  ----");
            Console.WriteLine(" ");
            Console.WriteLine("Páginas: " + pags.Length);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------");
            foreach (int elemento in pags)
                Console.Write(elemento + " | ");

            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" ");
            //
            
            //Algoritmo FIFO
            for (int i = 0; i < 10; i++) {
                if (i < 3)
                {
                    if (pags[i] != elementoFifo[0] && pags[i] != elementoFifo[1] && pags[i] != elementoFifo[2])
                    {
                        elementoFifo[i] = pags[i];
                        faltas++;
                        for (int n = 0; n < 3; n++)
                        {
                            Console.WriteLine("[ " + elementoFifo[n] + " ]");

                        }
                        Console.WriteLine("-----");
                    }
                }
                else
                {
                    if (pags[i] != elementoFifo[0] && pags[i] != elementoFifo[1] && pags[i] != elementoFifo[2])
                    {
                        elementoFifo[0] = elementoFifo[1];
                        elementoFifo[1] = elementoFifo[2];
                        elementoFifo[2] = pags[i];
                        faltas++;
                        for (int n = 0; n < 3; n++)
                        {
                            Console.WriteLine("[ " + elementoFifo[n] + " ]");
                        }
                        Console.WriteLine("-----");                        
                    }
                    else
                    {
                        repeticaoRit++;
                        for (int n = 0; n < 3; n++)
                        {
                            Console.WriteLine("[ " + elementoFifo[n] + " ]");
                        }
                        Console.WriteLine("-----");
                    }
                }
            }
            //
            
            //Impressão de fim
            Console.WriteLine("______________________");
            Console.WriteLine(" ");
            Console.WriteLine("Número de Faltas: " + faltas);
            Console.WriteLine("Elementos repetidos: " + repeticaoRit);
            Console.WriteLine("______________________");
            Console.ReadLine();
            Console.ReadKey();
            //
        }
    }
}

