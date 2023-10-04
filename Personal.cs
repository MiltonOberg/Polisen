using System.Text.Json;
using System;

class Personal
{
    public string Name{get; set;}
    public int Number{get; set;}
    public Personal(string name, int number)
    {
        Name = name;
        Number = number;  
    }

    public List<Personal> pList;
    public Personal()
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
        
        
        string jsonPersonal = JsonSerializer.Serialize(pList);
        File.WriteAllText("personal.json", jsonPersonal);
    }
    public void ShowPeronal()
    {
        for(int i = 0; i < pList.Count; i++)
        {
            Console.WriteLine($"{pList[i].Name}, {pList[i].Number}");
        }
    }
}