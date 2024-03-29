﻿// Elin Ericstam SUT21

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Gorilla : Monkey
    {
        public int _speed = 0;

        public Gorilla() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true, 0, 0) { }

        public Gorilla(string Rank, string Type, string Gender, int Age, string Diet, string LivingArea, bool IsWild, double Height, int Speed) 
                       : base(Rank, Type, Gender, Age, Diet, LivingArea, IsWild, Height)
        {
            this._speed = Speed;
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gorillan låter oooh ook ook ook!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public override void Climb()
        {
            Console.WriteLine("Gorillan klättrar upp i trädet.");

        }

        public override void Eat()
        {
            Console.WriteLine("Gorillan äter " + _diet);
        }

        public override void Sleep()
        {
            Console.WriteLine("Gorillan sover\n");
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för Gorilla");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Rank:\t\t\t {_rank}");
            Console.WriteLine($"Vilt djur:\t\t {_isWild}");
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
            Console.WriteLine($"Höjd:\t\t\t {_height} meter");
            Console.WriteLine($"Snabbhet:\t\t {_speed} km/h");
        }
    }
}
