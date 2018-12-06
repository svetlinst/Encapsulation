using System;

namespace P01_Class_Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            try
            {
                var box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.CalcSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalcLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.CalcVolume():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            

            

        }
    }
}
