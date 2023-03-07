using System;
// define a generics class named Student
public class Animal<T>
{
    // define a field of type T 
    public T data;

    // define a constructor of the Student class 
    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
}

class Program
{
    static void Main()
    {
        
        Animal<string> animalName = new Animal<string>("deer");

        
        Animal<int> averageLifespan = new Animal<int>(22);

       
        Animal<string> animalHabitat = new Animal<string>("forest");

        
        var endangered = false;
        Console.WriteLine(endangered);
        var extinct = false;
        Console.WriteLine(extinct);
    }
}



