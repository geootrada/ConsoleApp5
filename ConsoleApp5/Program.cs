using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // раскладывание картинок в альбоие по три в ряд

            int numberOfImages;
            int numberOfRows;
            int remainsOfImages;
            int numberOfImagesInRow = 3;

            Console.WriteLine("Здравствуйте, сейчас мы разложим ваши картинки по три в ряд!");
            Console.Write("Сколько у вас картинок: ");
            numberOfImages = Convert.ToInt32(Console.ReadLine());

            numberOfRows = numberOfImages / numberOfImagesInRow;
            remainsOfImages = numberOfImages - numberOfRows * numberOfImagesInRow;

            Console.WriteLine($"У вас получилось рядов {numberOfRows}, остаток ваших картинок {remainsOfImages}");
        }   
        
    }
}
