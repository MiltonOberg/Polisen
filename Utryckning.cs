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
class UtryckList
{
    public List<Utryckning> utryckList;
    public UtryckList()
    {
        utryckList = new List<Utryckning>();
    }
    public void Add(string crime, string place, int time, string cops)
    {
        utryckList.Add(new Utryckning(crime, place, cops, time));
    }
    public void JsonSaveUtryck()
    {
        string jsonUtryck = JsonSerializer.Serialize(utryckList);
        File.WriteAllText("utryckning.json", jsonUtryck);
    }
    public List<Utryckning> JsonLoadUtryck()
    {
        string jsonUtryck = File.ReadAllText("utryckning.json");
        utryckList = JsonSerializer.Deserialize<List<Utryckning>>(jsonUtryck);
        return utryckList;
    }
}
