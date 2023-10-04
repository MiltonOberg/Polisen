using System.Text.Json;
using System;

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