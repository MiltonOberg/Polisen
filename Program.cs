using System.Diagnostics;
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.ComponentModel;
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
    class Add
{
    public List<Personal> pList;
    public Add()
    {
        pList = new List<Personal>();
    }
    public void AddP()
    {
        Console.WriteLine("Vad heter polisen?");
        string name = Console.ReadLine();
        Console.WriteLine("Vad är polisens tjänstenummer?");
        int number = int.Parse(Console.ReadLine());
        pList.Add(new Personal(name, number));
    }
    public void ShowPeronal()
    {
        for(int i = 0; i < pList.Count; i++)
        {
            Console.WriteLine($"{pList[i].name},  {pList[i].number}");
        }
    }
    
    
}

class Utryckning
{
    public string crime; // typ av brott
    public int time; //vilken tid brottet inträffade.
    public string cops; //Vilka poliser som deltog
    public string plats; // plats .
    public List<Utryckning> utryckList;
    
    public Utryckning(string crime, string plats, string cops, int time)
    {
        this.crime = crime;
        this.plats = plats;
        this.cops = cops;
        this.time = time;
        utryckList = new List<Utryckning>();
    }
    public void Add(string crime, string plats, string cops, int time)
    {
        utryckList.Add(new Utryckning(crime, plats, cops, time));
    }
    
    
}

        public class Rapport
        {
        // ska innehålla rapportnummer, datum, station samt beskrivning
        //fält
        public string RapportNummer;
        public string Datum;
        public string Plats;
        public string Beskrivning;

        public void Rapportering()
        {
            Console.WriteLine("Rapport ID: ");
            RapportNummer = Console.ReadLine();
            Console.WriteLine("Datum: ");
            Datum = Console.ReadLine();
            Console.WriteLine("Plats: ");
            Plats = Console.ReadLine();
            Console.WriteLine("Beskriv händelseförloppet: ");
            Beskrivning = Console.ReadLine();        

            Console.WriteLine("Rapport ID: " + RapportNummer + "\nDatum: " + Datum + "\nHändelse: " + Beskrivning);
            System.Console.WriteLine("Stämmer detta? J/N");
            Console.ReadLine();
        }
        
    }    
     
class Meny
{
    public static void Main()
    {
        Rapport rapportInstance = new Rapport(); //för att kunna kalla på metoden
        Add Add = new Add();

        Console.WriteLine("1. Skriv rapport");
        Console.WriteLine("2. Lägg till personal");
        Console.WriteLine("3. Rapporter");
        Console.WriteLine("4. Exit");
        string choice = Console.ReadLine();

        while(true)
        {
            
            switch(choice)
            {
                case "1":
                    rapportInstance.Rapportering();
                    break;
                case "2":
                    Add.AddP();
                    Add.ShowPeronal();
                    break;
                case "3":

                    break;
                case "4":

                    return;
            }
        }
        
        
    }
}