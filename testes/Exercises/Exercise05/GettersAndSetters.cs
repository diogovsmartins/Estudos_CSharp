namespace Exercises
{   /*create a class with a get and a set to safely get and change a value, for that let's create 
    some variables like name and age*/
    public class GettersAndSetters
    {
        private string name="Diogo";
        private int age =21;

        public string Name {
            get {return name;}
            set {name = value;}
        }
        
        public int Age{
            get{return age;}
            set{age=value;}
        }
    }
}