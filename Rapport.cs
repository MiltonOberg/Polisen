 using System.Text.Json;
using System;
 public class Rapport
        {
        // ska innehålla rapportnummer, datum, station samt beskrivning
        //fält
        public string RapportNummer{ get; set; }
        public string Datum{ get; set; }
        public string Plats{ get; set; }
        public string Beskrivning{ get; set; }

        public Rapport(string rapportNummer, string datum, string plats, string beskrivning)
        {
            RapportNummer = rapportNummer;
            Datum = datum;
            Plats = plats;
            Beskrivning = beskrivning;
        }

        public List<Rapport> rapportList;
        public Rapport()
        {
            rapportList = new List<Rapport>();
        }
        public void RapportAdd()
        {
            JsonLoadRapport();
            Console.WriteLine("Rapportnummer:");
            string rapportNummer = Console.ReadLine();
            Console.WriteLine("Datum(YYYY-MM-DD): ");
            string datum = Console.ReadLine();
            Console.WriteLine("Ange platsen där händelsen inträffade: ");
            string plats = Console.ReadLine();
            Console.WriteLine("Beskriv händelsen: ");
            string beskrivning = Console.ReadLine();
            
            rapportList.Add(new Rapport(rapportNummer, datum, plats, beskrivning));
            JsonSaveRapport();

        }
    public void JsonSaveRapport()
    {
        string jsonUtryck = JsonSerializer.Serialize(rapportList);
        File.WriteAllText("rapport.json", jsonRapport);
    }
    public void JsonLoadRapport()
    {
        string jsonRapport = File.ReadAllText("rapport.json");
        rapportList = JsonSerializer.Deserialize<List<Rapport>>(jsonRapport);
    }
        public void ShowRapportlist()
    {
        JsonLoadRapport();
        Console.WriteLine(rapportList);
    }
}