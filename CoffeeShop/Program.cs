namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            
            string extra = Console.ReadLine();
            double price = 0;
            bool orderValid = true;
            if (drink == "coffee")
            {
                price = 1.00;

            }
            else if (drink == "tea")
            {
                price = 0.6;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                orderValid = false;
            }
            if (orderValid )
            {
                extra == 'sugar';
                price = price + 0.4;

            }
            else if (orderValid)
            {
                extra == "no";
                price = price;
            }

            else
            Console.WriteLine("Unknown drink");
            orderValid = false;


            Console.WriteLine("Final price: ${0:f2}", + price);
            
            
}

        }
    }
