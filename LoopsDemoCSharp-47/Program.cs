namespace LoopsDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            Console.WriteLine("WHILE LOOP:");

            var cont = "yes";

            while(cont == "yes")
            {
                Console.WriteLine("Continue? (Type 'yes' or 'no')");
                cont = Console.ReadLine();
            }

            var number = 0;

            while(number <= 5)
            {
                Console.WriteLine(number);
                number++;
            }

            //Do while loop
            Console.WriteLine("DO WHILE LOOP:");

            number = 0;

            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <= 5);

            //For loop
            Console.WriteLine("FOR LOOP:");

            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i} is the number we are on");
            }

            Console.WriteLine("--------");

            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{i} is the number we are on");
            }

            //Foreach loop
            Console.WriteLine("FOREACH LOOP:");

            var numbers = new int[] { 22, 3, 444, 500, 12 };

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
