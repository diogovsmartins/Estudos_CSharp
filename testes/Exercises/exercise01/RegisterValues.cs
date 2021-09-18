using System;

namespace Exercises
{   //Faça um programa que leia cinco valores reais e imprima o quadrado de cada um deles. 
	//Ao fim, imprima também o somatório dos cinco
     class RegisterValues
    {   const int N_VALUES=5;
        static void Main(string[] args)
        {  
            int input;
            double inputSqrt, total=0;
            for(int i=0; i<N_VALUES;i++){
                Console.WriteLine("Please type a number: ");
                input=Convert.ToInt32(Console.ReadLine());
                inputSqrt=Math.Pow(input, 2);
                Console.WriteLine(inputSqrt);
                total+=inputSqrt;
            }
            Console.WriteLine("You have inputed the numbers 5 times alredy, and the total value of your inputs squared is: "+ total);
            
        }
    }
}
