using System;
namespace Exercises
{   /*Faça um programa que leia os valores dos salários atuais dos funcionários de uma empresa 
	e imprima os valores com aumento. Se o salário for menor ou igual a R$ 500,00, 
	o programa deve aplicar um aumento de 0.10 (10%) e se for maior que R$ 500,00, 
	o aumento deve ser de 0.08 (8%). Assim como no nosso último exemplo, o usuário 
	é que deve informar quando deseja sair. Ou seja, ele deve digitar o salário de 
	um funcionário e o programa vai exibir o valor com o aumento. Depois ele deve 
	responder se deseja digitar outro salário ou não. Se ele responder que sim, 
	deve-se solicitar o novo salário e exibir o valor com aumento. Então, 
	torna-se a perguntar se ele deseja informar um novo salário e repetir o laço até que ele não queira 
	informar novos salários.*/
    public class CalcSalary
    {
        public static void Main(string[]args){
            double salary;
            do{
                Console.WriteLine("Type the name of the employee: ");
                string employee=Console.ReadLine();
                
                Console.WriteLine("Now type "+employee+"'s salary: ");
                salary=Convert.ToDouble(Console.ReadLine());
                if(salary<=500){
                    Console.WriteLine(salary*1.10);
                }
                else if(salary>500){
                    Console.WriteLine(salary*1.08);
                }
                


                Console.WriteLine("Wanna stop? (type 0 when you're asked about the salary to stop)");
            }while(salary!=0);
        }
    }
}
