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

        public void Print()
            {
                Console.WriteLine($"Rapport ID: {RapportNummer}\nDatum: {Datum}\nPlats: {Plats}\nBeskrivning: {Beskrivning}");
            }
            
        }
         public class SaveToFile
        {
        // spara till json
            public static void RapportData(string[]args)
            {
            List<Rapport> rapportList = new List<Rapport>();
            {
                new Rapport("000001", "1984-10-12", "Göteborg, Majorna", "Inbrott i lägenhet");
                new Rapport("000002", "1984-10-13", "Göteborg, Majorna", "Överfall av alkoholpåverkad man, 30-års åldern");
                new Rapport("000003", "1984-10-13", "Göteborg, Majorna", "Gripning av gärningsmän som rånat alkoholpåverkad man");
                new Rapport("000004", "1984-10-16", "Göteborg, Majorna", "Misstänk drogpåverkad kvinna, 40-års åldern, häktas.");
            };
            
            string strJson = JsonSerializer.Serialize(rapportList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("rapport.json", strJson);
            }

        
            // Load and print the saved reports
            string strJsonLoaded = File.ReadAllText("rapport.json");
            List<Rapport> loadedRapport = JsonSerializer.Deserialize<List<Rapport>>(strJsonLoaded);

            foreach (var report in loadedRapport)
            {
                report.Print();
            }
        }
    
        