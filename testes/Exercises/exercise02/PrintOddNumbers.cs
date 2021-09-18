using System;
namespace Exercises
{
     class PrintOddNumbers{
        //Faça um programa que imprima todos os números pares no intervalo de 1 a 100.
        const int N_OF_TIMES=30;
        public static void Main(string[]args){
            for (int i = 0; i < N_OF_TIMES; i++){
                if(i%2!=0){
                    Console.WriteLine("This is an even number: "+i);
                }
            }
        }
    }
}