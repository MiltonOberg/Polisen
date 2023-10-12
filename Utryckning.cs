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
        utryckList.Add(new Utryckning(crime, place, cops, time));
    }
    
}
class JsonUtryck
{
    Utryckning utryck = new Utryckning();
    List<Utryckning> utryckList;
    public void UtryckningListan()
    {
        new List<Utryckning>();
    }
    public void addToJsonUtryck()
    {
        utryckList.Add(utryck);
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