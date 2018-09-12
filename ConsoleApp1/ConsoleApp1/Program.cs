using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash("Flash-память", " NAND", 497,32);
            DVD dvd = new DVD("DVD-диск", " SH-224",200, 5);
            HDD hdd = new HDD("съемный HDD ", "SSHD 2000G", 150, 4, 30);
       
            string number;
       
            Console.WriteLine("1-Информация о носительей\n2-Pасчет общего количества памяти всех устройств \n3-Pасчет времени необходимого для копирования");
            Console.WriteLine("4-Pасчет необходимого количества носителей информации представленных типов для переноса информации \n0-Выход" );
            while (true)
            {
                Console.WriteLine("\n\n Введите: ");
                number = Convert.ToString(Console.ReadLine());





                if (number == "1")
                {
                    flash.SayFullName();
                    Console.WriteLine("\n\n");
                    dvd.SayFullName();
                    Console.WriteLine("\n\n");
                    hdd.SayFullName();
                }






                else if (number == "2")
                {
                    double Receiving = 0;
                    Receiving = flash.Memory + dvd.DVDMemory + (hdd.AmountSections * hdd.Sections);
                    Console.WriteLine("Oбщего количества памяти:" + Receiving + "ГБ");
                }





                else if (number == "3")
                {
                    double date = 0;
                    string number1;
                    double HDDMemory = hdd.Sections * hdd.AmountSections;
                    double QuantitiesHDD, QuantitiesFlash, QuantitiesDVD;
                    Console.WriteLine("Введите объем памяти который вам нужно скачать /ГБ: ");
                    number1 = Console.ReadLine();
                    double.TryParse(number1, out double peremen);
                    if (peremen > 5.0 && peremen < 500000000)
                    {
                        QuantitiesHDD = peremen / HDDMemory;
                        QuantitiesFlash = (peremen % HDDMemory) / flash.Memory;
                        QuantitiesDVD = ((peremen % HDDMemory) % flash.Memory) / dvd.DVDMemory;
                        date = ((HDDMemory * QuantitiesHDD* 1032) / hdd.SpeedUSB2 ) + ((flash.Memory * QuantitiesFlash* 1032) / flash.SpeedUSB3 ) + ((dvd.DVDMemory * QuantitiesDVD * 1032) / dvd.SpeedDVD);
                        Console.WriteLine("Pасчет времени необходимого для копирования = " + date / 3600 + "час " + (date % 3600) / 60 + "минут " + (date % 3600) % 60 + "секунд");
                    }
                    else if (peremen <= 5.0 && peremen >= 0)
                    {
                        Console.WriteLine("Pасчет времени необходимого для копирования меньше чем 25 секунд");
                    }
                    else if (peremen >= 500000000)
                    {
                        Console.WriteLine("Вы можете копировать меньше 500 миллион ГБ информаций");
                    }
                    else
                    {
                        Console.WriteLine("Ощибка при введении");
                    }
                }





                else if (number == "4")
                {
                    string number1;
                    double HDDMemory = hdd.Sections * hdd.AmountSections;
                    double QuantitiesHDD, QuantitiesFlash, QuantitiesDVD;
                    Console.WriteLine("Введите объем памяти который вам нужно скачать /ГБ: ");
                    number1 = Console.ReadLine();
                    double.TryParse(number1, out double peremen);
                    if (peremen > 5.0 && peremen < 500000000)
                    {
                        QuantitiesHDD = peremen / HDDMemory;
                        QuantitiesFlash = (peremen % HDDMemory) / flash.Memory;
                        QuantitiesDVD = ((peremen % HDDMemory) % flash.Memory) / dvd.DVDMemory;
                        Console.WriteLine("\n Pасчет необходимого количества носителей информации представленных типов для переноса информации: " + "\nHDD = " + QuantitiesHDD + "\nFlash-память = " + QuantitiesFlash + "\nDVD = " + QuantitiesDVD);
                    }
                    else if(peremen <= 5.0 && peremen >= 0)
                    {
                        Console.WriteLine("Pасчет необходимого количества носителей информации представленных типов для переноса информации:\nDVD = 1");
                    }
                    else if (peremen >= 500000000)
                    {
                        Console.WriteLine("Вы можете копировать меньше 500 миллион ГБ информаций");
                    }
                    else
                    {
                        Console.WriteLine("Ощибка при введении");
                    }
                }




                else if (number == "5")
                {
                    break;
                    break;
                }
                else
                {
                    Console.WriteLine("Ощибка, введите число от 0 до 5");
                }
            }
           Console.ReadLine();
        }
    }
}
