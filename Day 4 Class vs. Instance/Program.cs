using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age; // zmienna typu int dostępna dla wszystkich klas 
    public Person(int initialAge)  // sprawdzany jest obiekt Person jego wiek  
    {
        // Add some more code to run some checks on initialAge
        if (initialAge < 0) // jeżeli jest na -
        {
            Console.WriteLine("Age is not valid, setting age to 0."); // dodanie komunikatu że nie może tak wyglądać 
            this.age= 0; // ustawiany jest na 0 
        }
        else
        {
            this.age= initialAge; // przypisanie wieku jeżeli jest większy od 0
        }
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 
        if (this.age < 13)
        {
            Console.WriteLine("You are young.");
        }
        if( this.age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine(" You are old.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        this.age++;
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) 
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();         // wypisanie w jakim zakresie wiek jest 
            for (int j = 0; j < 3; j++) // 3 razy zwiększa wiek o 1
            {
                p.yearPasses();
            }
            p.amIOld(); // ponowne wypisanie wieku powiększonego o 3
            Console.WriteLine();
        }
    }
}
