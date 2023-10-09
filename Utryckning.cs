using System.Text.Json;
using System;

class Utryckning
{
    public string Crime{get; set;} // typ av brott
    public int Time{get;set;} //vilken tid brottet inträffade.
    public string Cops{get; set;} //Vilka poliser som deltog
    public string Place{get; set;} // plats .
    public List<Utryckning> utryckList;
    
    public Utryckning(string crime, string place, string cops, int time)
    {
        Crime = crime;
        Place = place;
        Cops = cops;
        Time = time; 
    }
    public Utryckning()
    {
        utryckList = new List<Utryckning>();
    }
    public void Add(string crime, string place, int time, string cops)
    {
        JsonLoad();
        utryckList.Add(new Utryckning(crime, place, cops, time));
        JsonSave();
    }
    public void JsonSave()
    {
        string jsonUtryck = JsonSerializer.Serialize(utryckList);
        File.WriteAllText("utryckning.json", jsonUtryck);
    }
    public void JsonLoad()
    {
        string jsonUtryck = File.ReadAllText("utryckning.json");
        utryckList = JsonSerializer.Deserialize<List<Utryckning>>(jsonUtryck);
    }
    public List<Utryckning>ShowUtlist()
    {   
        JsonLoad();
        return (utryckList);
    }
}