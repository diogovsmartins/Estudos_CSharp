using System;
namespace teste{
    class Program{
         const int constant=10; //constants are created using const + variable type + name and a value that matches the type of the variable.
        public static void Main (String[]args){
            Console.WriteLine("hello world");//method to print strings
            int number=10;
            double doubleNumber=100000L;
            String firstString="Hello everyone!";
            Console.WriteLine("this is a int in c#: "+number+"// and this is a double: "+doubleNumber+"// and this is a String variable: "+firstString);
            Console.WriteLine("this is a constant variable: "+constant);
            Console.WriteLine("Input your age here: ");
            int age=Convert.ToInt32(Console.ReadLine());//use readline to get and input from the user, the input is always considered a String, so if you need any other data type you'll have to cast it manually before calling the method.
            Console.WriteLine("Your age is: "+age);
            Console.WriteLine(Math.Round(-4.4));//Math is a method that has various functions, it can return you the highest or smallest value declared into his parameters using Max or Min, it can round a number to it's closest integer using Round, if value is .5 it will round it down, there are many other functions in this method, certainly it is one I should try to learn more later.
            Console.WriteLine(firstString.ToUpper()+" este é o numero de letras dessa string");

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};//arrays in c# are created declarin the type of data and [] to indicate tha that's an array, you dont have to declare the size of the array when you create the variable
            foreach (string i in cars) 
            {
            Console.WriteLine(i);
            }//foreach loop, used to go through an array
            
            Array.Sort(cars);//method sort is a function derived from the method Array that sorts an array alphabetically or in an ascending order
            foreach (string i in cars){
                Console.WriteLine(i);
            }
            
        }
    }
} 