using System.Text.Json;
using System;
using System.Diagnostics.Contracts;
using System.IO.Pipes;
using System.Diagnostics;

class Personal
{
    public string Name{get; set;}
    public int Number{get; set;}
    public List<Personal> pList;
    
    public Personal(string name, int number)
    {
        Name = name;
        Number = number;  
    }
    public Personal()
    {
        JsonLoad();
        pList = new List<Personal>();
        JsonSave();
    }
    public void Add(string name, int number)
    {
        pList.Add(new Personal(name, number));
    }
    public void JsonSave()
    {
        string jsonPersonal = JsonSerializer.Serialize(pList);
        File.WriteAllText("personal.json", jsonPersonal);
    }
    public void JsonLoad()
    {
        string jsonPersonal = File.ReadAllText("personal.json");
        pList = JsonSerializer.Deserialize<List<Personal>>(jsonPersonal);
    }
    public List<Personal> ShowPersonal()
    {
        JsonLoad();
        return pList;
    }
}
