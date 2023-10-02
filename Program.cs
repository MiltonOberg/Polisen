using System.Diagnostics;
using System;

class Personal
{
    public string name;
    public int number;
    public Personal(string name, int number)
    {
        this.name = name;
        this.number = number;
    }
}
class Utrycking
{
    public string crime; // typ av brott
    public int time; //vilken tid brottet inträffade.
    
    public string poliser; //Vilka poliser som deltog
    public string plats; // plats .

    public void Utryckning(string crime, string plats, string poliser, int time)
    {
        this.crime = crime;
        this.plats = plats;
        this.poliser = poliser;
        this.time = time;
    }

}
class Rapport
{
 // ska innehålla rapportnummer, datum, station samt beskrivning
    int RapportNummer = Int32.Parse(Console.WriteLine("Skriv in rapport nummer (6 nummer): "));
    string Datum; 
    string station;
    string Beskrivning;
    
    public void Rapportering()
    {
        
    Console.WriteLine("Rapportnummer");
    Console.WriteLine("Datum");
    Console.WriteLine("Station");
    Console.WriteLine("Beskrivning");
    }
    
    
 
}

class Meny
{
    public void Menyn()
    {
        Console.WriteLine("1. Skriv rapport");
        Console.WriteLine("2. Personal");
        Console.WriteLine("3. Rapporter");
        Console.WriteLine("4");
        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                
                break;
            case "2":

                break;
            case "3":

                break;
            case "4":
            
                break;
        }
    }
}