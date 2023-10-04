using System.Diagnostics;
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text.Json;


        public class Rapport
        {
        // ska innehålla rapportnummer, datum, station samt beskrivning
        //fält
        public string RapportNummer;
        public string Datum;
        public string Plats;
        public string Beskrivning;

        public void Rapportering()
        {
            Console.WriteLine("Rapport ID: ");
            RapportNummer = Console.ReadLine();
            Console.WriteLine("Datum: ");
            Datum = Console.ReadLine();
            Console.WriteLine("Plats: ");
            Plats = Console.ReadLine();
            Console.WriteLine("Beskriv händelseförloppet: ");
            Beskrivning = Console.ReadLine();        

            Console.WriteLine("Rapport ID: " + RapportNummer + "\nDatum: " + Datum + "\nHändelse: " + Beskrivning);
            System.Console.WriteLine("Stämmer detta? J/N");
            Console.ReadLine();
        }
        
    }    
     
class Meny
{
    public static void Main()
    {
        Rapport rapportInstance = new Rapport(); //för att kunna kalla på metoden
        PersonalList personalList = new PersonalList();
        Utryckning utryck = new Utryckning();
        while(true)
        {
            Console.WriteLine("1. Skriv rapport");
            Console.WriteLine("2. Lägg till personal");
            Console.WriteLine("3. Ny utrikting");
            Console.WriteLine("4. Arkiv");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();
            
            switch(choice)
            {
                case "1":
                    rapportInstance.Rapportering();
                    break;
                case "2":
                    personalList.Add();
                    break;
                case "3":
                    utryck.Add();
                    break;
                case "4":

                    break;
                case "5":
                    return;
            }
        }
        
        
    }
}