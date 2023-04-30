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
    public T getAnimal()
    {
        return data;
    }
}


class Program
{
    static void Main()
    {
        
        Animal<string> animalName = new Animal<string>("deer");

        
        Animal<int> averageLifespan = new Animal<int>(22);

       
        Animal<string> animalHabitat = new Animal<string>("forest");

        Animal<bool>endangered=new Animal<bool>(false);

        Animal<bool> extinct = new Animal<bool>(false);
        //var endangered = false;
        //Console.WriteLine(endangered);
        //var extinct = false;
        // Console.WriteLine(extinct);
    }
}


