using System.Diagnostics;
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text.Json;


     
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
                    Rapport.RapportData();
                    break;
                case "2":
                    personalList.Add();
                    break;
                case "3":
                    utryck.Add();
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

                                break;
                            case "2":
                                personalList.ShowPersonal();
                                break;
                            case "3":
                                utryck.ShowUtlist();
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