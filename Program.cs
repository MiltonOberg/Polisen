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
    class PersonalList
{
    public List<Personal> pList;
    public PersonalList()
    {
        pList = new List<Personal>();
    }
    public void Add()
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
    public string place; // plats .
    
    
    public Utryckning(string crime, string place, string cops, int time)
    {
        this.crime = crime;
        this.place = place;
        this.cops = cops;
        this.time = time; 
    }
}
class UtLista
{
    public List<Utryckning> utryckList;
    public UtLista()
    {
        utryckList = new List<Utryckning>();
    }
    public void Add()
    {
        Console.WriteLine("Vad var det för brott?");
        string crime = Console.ReadLine();
        Console.WriteLine("Var skedde utryckningen?");
        string place = Console.ReadLine();
        Console.WriteLine("Vilken tid skedde utryckningen?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("Och slutligen vilka poliser var på utryckningen?");
        string cops = Console.ReadLine();
        
        utryckList.Add(new Utryckning(crime, place, cops, time));
    }
    public void ShowUtlist()
    {
        for(int i = 0; i < utryckList.Count; i++)
        {
            Console.WriteLine($"Utryckning {i + 1}: {utryckList[i].crime}, {utryckList[i].place}, {utryckList[i].time}, {utryckList[i].time}");
        }
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
        PersonalList PersonalList = new PersonalList();
        UtLista utryck = new UtLista();
        while(true)
        {
            Console.WriteLine("1. Skriv rapport");
            Console.WriteLine("2. Lägg till personal");
            Console.WriteLine("3. Rapporter");
            Console.WriteLine("4.Arkiv");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();
            
            switch(choice)
            {
                case "1":
                    rapportInstance.Rapportering();
                    break;
                case "2":
                    PersonalList.Add();
                    break;
                case "3":
                    utryck.Add();
                    break;
                case "4":

                    break;
                case "5":
                    return;
            }
        }
        
        
    }
}