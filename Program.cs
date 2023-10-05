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
        PersonalList PersonalList = new PersonalList();
        UtLista utryck = new UtLista();
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
                    PersonalList.Add();
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