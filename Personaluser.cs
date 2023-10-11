public class User
{
   // Rapport rapportInstance = new Rapport(); //för att kunna kalla på metoden
    Personal personalList = new Personal();
    Utryckning utryck = new Utryckning();
    public void PersonalUser()
    {
        Console.WriteLine("Vad heter polisen?");
        string name = Console.ReadLine();
        Console.WriteLine("Vad är polisens tjänstenummer?");
        int number = int.Parse(Console.ReadLine());
        personalList.Add(name, number);
        
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