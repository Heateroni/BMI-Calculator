using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What measurement system do you want to use (metric/imperial): ");
            string unit = Console.ReadLine();

            if (unit == "metric")
            {
                Console.Clear();
                Console.Write("Enter your weight in kilograms: ");
                float weightKG = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("What is your height in meters: ");
                float metricHeight = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float heightSq = metricHeight * metricHeight;
                float mBMI = weightKG / heightSq;
                Console.WriteLine("Your BMI is " + mBMI);
                if (mBMI <= 24.9)
                {
                    Console.WriteLine("Your BMI is less the 24.9 making you in the healthy weight catagory, congratulations!");
                }
                else if (mBMI >= 25)
                {
                    Console.WriteLine("Your BMI is 25 or over, making you clinically overweight. Time to lay off the doughnuts!");
                }
                
            }
            else if (unit == "imperial")
            {
                float wConversion = Convert.ToSingle(0.453592);
                float hConversion = Convert.ToSingle(0.0254);
                Console.Clear();
                Console.Write("Enter your weight in pounds: ");
                float weightLBS = Convert.ToSingle(Console.ReadLine());
                float _weightLBS = weightLBS * wConversion;
                Console.Clear();
                Console.Write("What is your height in inches: ");
                float imperialHeight = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float _imperialHeight = imperialHeight * hConversion;
                float __imperialHeight = _imperialHeight * _imperialHeight;
                float iBMI = _weightLBS / __imperialHeight;
                Console.WriteLine("Your BMI is " + iBMI);
                if (iBMI <= 24.9)
                {
                    Console.WriteLine("Your BMI is less the 24.9 making you in the healthy weight catagory, congratulations!");
                }

                else if ( iBMI >= 25)
                {
                    Console.WriteLine("Your BMI is 25 or over, making you clinically overweight. Time to lay off the doughnuts!");
                }
            }

            Console.ReadKey(); // Stops the program from closing the instance
        }
    }
}