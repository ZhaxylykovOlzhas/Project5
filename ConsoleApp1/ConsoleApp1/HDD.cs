using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class HDD: Storage
    {
        public double SpeedUSB2 { get; set; }
        public double Sections { get; set; }
        public double AmountSections { get; set; }
        public HDD(string MediaName, string Model, int speedUSB2, int sections ,int amountSections) : base(MediaName, Model)
        {
            SpeedUSB2 = speedUSB2;
            Sections = sections;
            AmountSections = amountSections;
        }

        public override void SayFullName()
        {
            Console.WriteLine("Название носителя: " + MediaName);
            Console.WriteLine("Модель HDD: " + Model);
            Console.WriteLine("Скорость HDD: " + SpeedUSB2+ " Гбит/c");
            Console.WriteLine("Kоличество разделов: " + Sections);
            Console.WriteLine("Oбъем разделов.: " + AmountSections);
        }
    }
}