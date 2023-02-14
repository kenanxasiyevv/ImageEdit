
using System.Drawing;

namespace ImageEdit
{
     class Program
    {
        static void Main(string[] args)
        {
            var imageProcessing= new ImageProcessing();
           
            string key = "";
            while (key != "quit")
            {

                Console.Write("enter path:");
                string imagePath = (Console.ReadLine());
                Bitmap image = new Bitmap(imagePath);


                Console.WriteLine($"1.Random Filter\n2.Custom Filter");

            start:
                key = Console.ReadLine();


                switch (key)
                {
                    case "1":
                        var random = new Random();
                        int r = random.Next(0, 255);
                        int g = random.Next(0, 255);
                        int b = random.Next(0, 255);
                        Bitmap newRandmImage = imageProcessing.ChangePixelColor(image, r, g, b);
                        imageProcessing.SaveFile(newRandmImage);
                        image.Dispose();
                        break;
                    case "2":
                        Console.Write("R:");
                        int colorR = int.Parse(Console.ReadLine());
                        Console.Write("G:");
                        int colorG = int.Parse(Console.ReadLine());
                        Console.Write("B:");
                        int colorB = int.Parse(Console.ReadLine());
                        Bitmap newImage = imageProcessing.ChangePixelColor(image, colorR, colorG, colorB);
                        imageProcessing.SaveFile(newImage);
                        image.Dispose();
                        break;
                    default:
                        Console.WriteLine("switch correct case:");
                        goto start;

                }
            }
        }
    }
} 