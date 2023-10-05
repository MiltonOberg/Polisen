using System.Text.Json;
using System;
using System.Diagnostics.Contracts;

class Personal
{
    public string Name{get; set;}
    public int Number{get; set;}
    public Personal(string name, int number)
    {
        Name = name;
        Number = number;  
        
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
        JsonLoad();
        Console.WriteLine("Vad heter polisen?");
        string name = Console.ReadLine();
        Console.WriteLine("Vad är polisens tjänstenummer?");
        int number = int.Parse(Console.ReadLine());
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
        Console.WriteLine(pList);

    }
}
