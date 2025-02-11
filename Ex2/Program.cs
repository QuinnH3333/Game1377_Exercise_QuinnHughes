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

            for (int i = 0; i <= 9; i++)
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

            float average = 0f;
            for (int i = 9; i >= 0; i--)
            {
                average = average + intValues[i];
            }
            average = average / intValues.Length;
            Console.WriteLine("The average is: " + average);


            for (int i = 0; i <= 9; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Every other: " + intValues[i]);
                }
            }


            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Every third: " + intValues[i]);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Enter array size");
            string? inputArraySize = (Console.ReadLine());
            int.TryParse(inputArraySize, out int parsedArraySize);


            Console.WriteLine("Enter array range min");
            string? inputRangeMin = (Console.ReadLine());
            int.TryParse(inputRangeMin, out int parsedRangeMin);

            Console.WriteLine("Enter array range max");
            string? inputRangeMax = (Console.ReadLine());
            int.TryParse(inputRangeMax, out int parsedRangeMax);

            Console.WriteLine("Array size : " + parsedArraySize + ". Range: " + parsedRangeMin + "," + parsedRangeMax);

            int[] generatedArray = GenerateArray(parsedArraySize, parsedRangeMin, parsedRangeMax); //storing the new array
            for (int i = 0; i < parsedArraySize; i++)
            {
                Console.Write(generatedArray[i] + ", ");
            }

        }
        static int[] GenerateArray(int length, int min, int max)
        {
            Random rnd = new Random();
            int[] generateArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                generateArray[i] = rnd.Next(min, max);
            }
            return generateArray;
        }
    }
}

