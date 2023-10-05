using System.Text.Json;
using System;

class Utryckning
{
    public string Crime{get; set;} // typ av brott
    public int Time{get;set;} //vilken tid brottet inträffade.
    public string Cops{get; set;} //Vilka poliser som deltog
    public string Place{get; set;} // plats .
    
    
    public Utryckning(string crime, string place, string cops, int time)
    {
        Crime = crime;
        Place = place;
        Cops = cops;
        Time = time; 
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

        string jsonUtryckning = JsonSerializer.Serialize(utryckList);
        File.WriteAllText("Utryckning.json", jsonUtryckning);
    }
    public void ShowUtlist()
    {
        for(int i = 0; i < utryckList.Count; i++)
        {
            Console.WriteLine($"Utryckning {i + 1}: {utryckList[i].Crime}, {utryckList[i].Place}, {utryckList[i].Cops}, {utryckList[i].Time}");
        }
    }
}