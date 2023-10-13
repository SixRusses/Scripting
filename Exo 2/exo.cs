using System;

public class Program
{
    public static void Main()
    {
    
        Console.Clear();
        Console.WriteLine("Veuillez saisir l'identifiant");

        string id = Console.ReadLine();
        string idMaj = ConvertToUpper(id);

        Console.WriteLine(idMaj);

    }

    public static string ConvertToUpper(string text)
    {
       return text.ToUpper();
    }
}