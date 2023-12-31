﻿using System.Diagnostics;
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
        PersonalList personalList = new PersonalList();
        UtryckList utryck = new UtryckList();
        UserInterface userInterface = new UserInterface();
        
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
                    userInterface.RapportUser();
                    break;
                case "2":
                    personalList.JsonLoad();
                    userInterface.PersonalUser();
                    personalList.JsonSave();
                    break;
                case "3":
                    utryck.JsonLoadUtryck();
                    userInterface.Utryckning();
                    utryck.JsonSaveUtryck();
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

                                List<Rapport> rapportList = rapportInstance.ShowRapportList();
                                for(int i = 0; i < rapportList.Count; i++)
                                {
                                    Console.WriteLine($"RapportNummer: {rapportList[i].RapportNummer}\nDatum: {rapportList[i].Datum}\nPlats: {rapportList[i].Plats}\nBeskrivning: {rapportList[i].Beskrivning}");
                                    Console.WriteLine("\n");
                                }
                                break;
                            case "2":
                                
                                List<Personal> pList = personalList.JsonLoad();
                                for(int i = 0; i < pList.Count; i++)
                                {
                                    Console.WriteLine($"{pList[i].Name}, {pList[i].Number}");
                                }
                                break;
                            case "3":

                                List<Utryckning> utryckList = utryck.JsonLoadUtryck();
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