using System.Text.Json;
using System;
using System.Diagnostics.Contracts;
using System.IO.Pipes;
using System.Diagnostics;
using System.Configuration.Assemblies;

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
        public void Add(string name, int number)
        {
            pList.Add(new Personal(name, number));
        }
        public void JsonSave()
        {
            string jsonPersonal = JsonSerializer.Serialize(pList);
            File.WriteAllText("personal.json", jsonPersonal);
        }
        public List<Personal> JsonLoad()
        {
            string jsonPersonal = File.ReadAllText("personal.json");
            pList = JsonSerializer.Deserialize<List<Personal>>(jsonPersonal);
            return pList;
        }
    }

