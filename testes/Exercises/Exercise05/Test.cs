using System;
namespace Exercises
{
    public class Test
    {
        public static void Main(string[]args){
            GettersAndSetters myObj= new GettersAndSetters();

            Console.WriteLine("Before the change with the get method: "+myObj.Name);
            myObj.Name="ariana";
            Console.WriteLine("After the change: "+myObj.Name);
        
            Console.WriteLine("Before the change: "+myObj.Age);
            myObj.Age=30;
            Console.WriteLine("After the change: "+myObj.Age);
        }
    }
}