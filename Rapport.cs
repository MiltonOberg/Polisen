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
        public List<Rapport> rapportList;
        public Rapport(string rapportNummer, string datum, string plats, string beskrivning)
        {
            RapportNummer = rapportNummer;
            Datum = datum;
            Plats = plats;
            Beskrivning = beskrivning;
        }


        public Rapport()
        {
            rapportList = new List<Rapport>();
        }
        public void RapportAdd(string rapportNummer, string datum, string plats, string beskrivning)
        {
            JsonLoadRapport();
            rapportList.Add(new Rapport(rapportNummer, datum, plats, beskrivning));
            JsonSaveRapport();

        }
    public void JsonSaveRapport()
    {
        string jsonRapport = JsonSerializer.Serialize(rapportList);
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
        for(int i = 0; i < rapportList.Count; i++)
        {
            Console.WriteLine($"RapportNummer: {rapportList[i].RapportNummer}\nDatum: {rapportList[i].Datum}\nPlats: {rapportList[i].Plats}\nBeskrivning: {rapportList[i].Beskrivning}");
            Console.WriteLine("\n");
        }
        Console.ReadLine();    
    }
}