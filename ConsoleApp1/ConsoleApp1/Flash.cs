using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Flash : Storage
    {
        public double SpeedUSB3 { get; set; }
        public double Memory { get; set; }

        public Flash(string MediaName, string Model, int speedUSB3, int memory) : base(MediaName, Model)
        {
         SpeedUSB3 = speedUSB3;
            Memory = memory;
        }
        
        public override void SayFullName()
        {
            Console.WriteLine("Название носителя: " + MediaName);
            Console.WriteLine("Модель Flash-память: " + Model);
            Console.WriteLine("Скорость Flash-память: " + SpeedUSB3+" Гбит/c");
            Console.WriteLine("Тип Flash-память: " + Memory+" ГБ");
        }

    }
}
