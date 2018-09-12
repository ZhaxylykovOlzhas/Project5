using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Storage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }

        public Storage(string mediaName, string model)
        {
            MediaName = mediaName;
            Model = model;
        }
        // vistual - ключевое слова , у наследниках должен переопреденен.
        public virtual void SayFullName()
        {
            Console.WriteLine($"{MediaName} {Model}");

        }
        // abstract -  ключевое слова , это метод обязан быть определен у каждого наследника
    }
}
