using System;
namespace Exercises
{   
    public class newclass
    {
        public static void Main(string[]args){
            FunctionClass myObj=new FunctionClass();
            myObj.ola("diogo");
            Console.WriteLine(myObj.sum(33,56));
            Console.WriteLine(myObj.testEcho(24));
        }
        
    }
        
}