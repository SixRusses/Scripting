using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if(int.TryParse(Console.ReadLine(), out int number))
        {
           if (number % 2 == 0) {
            Console.WriteLine(number + " est pair");
           } else {
            Console.WriteLine(number + " est impair");
           }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}