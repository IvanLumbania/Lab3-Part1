using System.Threading.Channels;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dogs Name:");

            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.Name = dogName;
            dog.color = "Brown";
            dog.age = 12;

            Console.WriteLine($"Name of the dog is: {dog.Name}") ;
            Console.WriteLine($"The colour of the dog is: {dog.color}");
            Console.WriteLine($"The age of the dog is: {dog.age}");
            dog.Eat();


            Console.WriteLine("\nEnter Cats Name:");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.Name = catName;
            cat.color = "purple";
            cat.age = 4;

            Console.WriteLine($"The name of the cat is: {cat.Name}");
            Console.WriteLine($"Colour of the cat is: {cat.color}");
            Console.WriteLine($"The age of the cat is: {cat.age}");
            cat.Eat();

            //Prevents code from exiting right away
            Console.ReadLine();


        }
    }
}
