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
    
    List<Personal> pList;
    public PersonalList()
    {
        pList = new List<Personal>();
    }
    public void Add(string name, int number)
    {
        pList.Add(new Personal(name, number));
    }
    public void Print()
    {
        for(int i = 0; i < pList.Count; i++)
        {
            Console.WriteLine($"Namn: {pList[i].name}: {pList[i].number}");
        }
    }
    
}
class Utryckning
{
public string crime; // typ av brott
public int time; //vilken tid brottet inträffade.

public string cops; //Vilka poliser som deltog
public string plats; // plats .

public Utryckning(string crime, string plats, string cops, int time)
{
    this.crime = crime;
    this.plats = plats;
    this.cops = cops;
    this.time = time;
}
class UtList
{
List<Utryckning> utryckList;
public UtList()
{
    utryckList = new List<Utryckning>();
}
public void Add(string crime, string plats, string cops, int time)
{
    utryckList.Add(new Utryckning(crime, plats, cops, time));
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
        

        PersonalList pList = new PersonalList();
        pList.Add("calle", 1231);
        pList.Add("Milton", 8469);
        pList.Add("Brian", 6263);

        Console.WriteLine("1. Skriv rapport");
        Console.WriteLine("2. Personal");
        Console.WriteLine("3. Rapporter");
        Console.WriteLine("4");
        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                rapportInstance.Rapportering();
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