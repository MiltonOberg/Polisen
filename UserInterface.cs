using System;


public class UserInterface
{
    Rapport rapportList = new Rapport(); //för att kunna kalla på metoden
    PersonalList pList = new PersonalList();
    UtryckList utryck = new UtryckList();


    public void RapportUser()
    {
            Console.WriteLine("Rapportnummer(6-siffror):");
            string rapportNummer = Console.ReadLine();
            Console.WriteLine("Datum(YYYY-MM-DD): ");
            string datum = Console.ReadLine();
            Console.WriteLine("Ange platsen där händelsen inträffade: ");
            string plats = Console.ReadLine();
            Console.WriteLine("Beskriv händelsen: ");
            string beskrivning = Console.ReadLine();
            
            rapportList.RapportAdd(rapportNummer, datum, plats, beskrivning);

    }
   // Rapport rapportInstance = new Rapport(); //för att kunna kalla på metoden
    
    public void PersonalUser()
    {
        
        Console.WriteLine("Vad heter polisen?");
        string name = Console.ReadLine();
        Console.WriteLine("Vad är polisens tjänstenummer?");
        int number = int.Parse(Console.ReadLine());
        pList.Add(name, number);
        
    }
    public void Utryckning()
    {
        Console.WriteLine("Vad var det för brott?");
        string crime = Console.ReadLine();
        Console.WriteLine("Var skedde utryckningen?");
        string place = Console.ReadLine();
        Console.WriteLine("Vilken tid skedde utryckningen?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("Och slutligen vilka poliser var på utryckningen?");
        string cops = Console.ReadLine();
        utryck.Add(crime, place, time, cops);
    }
}




