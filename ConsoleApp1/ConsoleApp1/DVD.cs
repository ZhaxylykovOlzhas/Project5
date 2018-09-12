using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class DVD : Storage
    {
        public double SpeedDVD { get; set; }
        public double DVDMemory { get; set; }


        public DVD(string MediaName, string Model, int speedDVD,int DVDmemory) : base(MediaName, Model)
        {
            SpeedDVD = speedDVD;
            DVDMemory = DVDmemory;
        }

        public override void SayFullName()
        {
            Console.WriteLine("Название носителя: " + MediaName);
            Console.WriteLine("Модель DVD: " + Model);
            Console.WriteLine("Скорость DVD: " + SpeedDVD+ " Гбит/c");
            Console.WriteLine("Объем памяти DVD: " + DVDMemory+ " ГБ");

        }
        
      
    }
}
