using System.Text.Json;
using System;
using System.Diagnostics.Contracts;

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
        pList = new List<Personal>();
    }
    
    public void Add(string name, int number)
    {
        JsonLoad();
        
        pList.Add(new Personal(name, number));
        JsonSave();
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

    public void ShowPersonal()
    {
        JsonLoad();
        for(int i = 0; i < pList.Count; i++)
        {
            Console.WriteLine($"{pList[i].Name}, {pList[i].Number}");
        }
    }
}
