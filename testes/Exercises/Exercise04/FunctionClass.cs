using System;
namespace Exercises
{   //create a function that says the name of the person and a message like "hello + name"
    public class FunctionClass
    {
        public void ola(string name){
            Console.WriteLine("Hello "+name+", have a nice day.");
        }
    //create a function that returns the sum of 2 numbers
        public int sum(int x, int y){
            int result=x+y;
            return result;
        }
        
    //A banda The XPTOs vai gravar o seu primeiro disco! Eles foram em vários estúdios de amigos e perceberam que,
    // ao tocar, existia um eco em alguns deles. Alguns estudios que eles visitaram tinham 8, 16, 18, 24, 36
    // metros entre os amplificadores e as paredes opostas
    //Sabendo que as pessoas conseguem perceber o eco num tempo maior ou igual a 0,1s. C
    // crie uma função que consiga determinar se há eco em um estudio de acordo com a distância
    // entre os amplificadores e a parede oposta, considerando a velocidade do som como 340m/s?
        public bool testEcho(int distance){
            const int speedOfSound=340;
            const double minimalTime=0.1;
            double minimalDistance =(speedOfSound*minimalTime)/2;
            bool echo=distance>minimalDistance;
            return echo;
        }
    }
}