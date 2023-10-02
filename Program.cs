using System.Diagnostics;
using System;
using System.IO.Pipes;

class Personal
{
    public string name;
    public int number;
    public List<Personal> pList;
    public Personal(string name, int number)
    {
        this.name = name;
        this.number = number;
        pList = new List<Personal>();
    }
    public void Add(string name, int number)
    {
        pList.Add(new Personal(name, number));
    }
    
}
class Utryckning
{
    public string crime; // typ av brott
    public int time; //vilken tid brottet inträffade.
    
    public string poliser; //Vilka poliser som deltog
    public string plats; // plats .

    public Utryckning(string crime, string plats, string poliser, int time)
    {
        this.crime = crime;
        this.plats = plats;
        this.poliser = poliser;
        this.time = time;
    }
    

}
        public class Rapport
        {
 // ska innehålla rapportnummer, datum, station samt beskrivning
    
        //fält
        int RapportNummer;
        string Datum;
        string Plats;
        string Beskrivning;

        void Rapportering()
        {
            Console.WriteLine("Rapport ID: ");
            RapportNummer = Convert.ToInt32();
            Console.WriteLine("Datum: ");
            Datum = Console.ReadLine();
            Console.WriteLine("Plats: ");
            Plats = Console.Readline();
            Console.WriteLine("Beskriv händelseförloppet: ");
            Beskrivning = Console.ReadLine();        

            Console.WriteLine("Rapport ID: " RapportNummer "/n" + "Datum: " + Datum + "/nHändelse: " + Beskrivning);
            System.Console.WriteLine("Stämmer detta? J/N");
            Console.ReadLine();
        }
        
    }    
     

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

class Program
{
    public static void Main()
    {
        
        
    }
}