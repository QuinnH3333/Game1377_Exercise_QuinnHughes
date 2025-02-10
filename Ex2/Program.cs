namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch();
            LoopsAndArrays();

        }
        static void Switch()
        {   //switch
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
        static void LoopsAndArrays()
        {
            int[] intValues = [100, 94, 159, -783, 132, 179, 47, 107, 135, 50];

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(intValues[i]);
            }


            bool inputBool = false;
            while (inputBool == false)
            {
                Console.WriteLine("Input a number in the Array.");
                string? inputString = (Console.ReadLine());

                if (!string.IsNullOrEmpty(inputString))
                //if (inputString) is NOT Null or Empty
                {
                    int.TryParse(inputString, out int parsedInput);
                    //Try to Parse/convert the inputString into an int.
                    //If parsing fails the resulting int is turned to 0. This is useful for dealing with empty inputs.
                    for (int i = 9; i >= 0; i--)
                    {
                        inputBool = (parsedInput == intValues[i]);
                        if (inputBool)
                        {
                            break; // Stop the loop if match is found
                        }
                    }
                }
                else
                {
                    inputBool = false; // If input is invalid (null or empty), set inputBool to false
                }
            }
            Console.WriteLine("Loop Exited");
        }
    }
}

