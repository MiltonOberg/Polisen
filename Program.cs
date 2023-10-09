using System.Diagnostics;
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text.Json;
using System.Net.Quic;



class Meny
{
    public static void Main()
    {
     
        Rapport rapportInstance = new Rapport(); //för att kunna kalla på metoden
        Personal personalList = new Personal();
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
                    rapportInstance.RapportAdd();
                    break;
                case "2":

                    Console.WriteLine("Vad heter polisen?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Vad är polisens tjänstenummer?");
                    int number = int.Parse(Console.ReadLine());
                    personalList.Add(name, number);
                    break;
                case "3":

                    Console.WriteLine("Vad var det för brott?");
                    string crime = Console.ReadLine();
                    Console.WriteLine("Var skedde utryckningen?");
                    string place = Console.ReadLine();
                    Console.WriteLine("Vilken tid skedde utryckningen?");
                    int time = int.Parse(Console.ReadLine());
                    Console.WriteLine("Och slutligen vilka poliser var på utryckningen?");
                    string cops = Console.ReadLine();
                    utryck.Add(crime, place, time, cops);
                    break;
                case "4":

                    bool runAgain = true;
                    Console.WriteLine("Arkiv. Vad är det du vill ta en titt på?");
                    while(runAgain)
                    {
                        Console.WriteLine("1. Arkiv för rapporter");
                        Console.WriteLine("2. Arkiv för personal");
                        Console.WriteLine("3. Arkiv för utryckningar");
                        Console.WriteLine("4. För att backa till huvudmenyn");
                        choice = Console.ReadLine();
                        switch(choice)
                        {
                            case "1":
                                rapportInstance.RapportAdd();
                                break;
                            case "2":
                                                       
                                List <Personal> pList = personalList.ShowPersonal();
                                for(int i = 0; i < pList.Count; i++)
                                {
                                    Console.WriteLine($"{pList[i].Name}, {pList[i].Number}");
                                }
                                break;
                            case "3":

                                List<Utryckning> utryckList = utryck.ShowUtlist();
                                for(int i = 0; i < utryckList.Count; i++)
                                    {
                                        Console.WriteLine($"Brott: {utryckList[i].Crime} Plats: {utryckList[i].Place} Poliser: {utryckList[i].Cops} Tid: {utryckList[i].Time}");
                                    }
                                break;
                            case "4":
                            
                                runAgain = false;
                                break;
                        }
                    }
                    break;
                case "5":
                    return;
            }
        }
        
        
    }
}