namespace AreaFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
           
            
            double AreaFigures = 0;
            if (figures == "square")
            {
                double a = double.Parse(Console.ReadLine());
                AreaFigures = a * a;
                Console.WriteLine($"{AreaFigures:f2}");
            }
            else if (figures == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                AreaFigures = a * b;
                Console.WriteLine($"{AreaFigures:f2}");
            }
            else if (figures == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                AreaFigures = a * a * Math.PI;
                Console.WriteLine($"{AreaFigures:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

            }

            }
    }
