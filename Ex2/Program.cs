namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch();
        }
        static void Switch()
        {
            Console.WriteLine("Input a WASD key, then press enter.");
            string? caseString = Console.ReadLine();
            caseString = caseString?.ToUpper();
           
            switch (caseString)
            {
                case "W":
                    Console.WriteLine("You moved up");
                    break;
                case "A":
                    Console.WriteLine("You moved left");
                    break;
                case "S":
                    Console.WriteLine("You moved down");
                    break;
                case "D":
                    Console.WriteLine("You moved Right");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            } 

        }
    }
}

