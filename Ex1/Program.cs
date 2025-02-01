namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
            Arithmetic();
            Assignment();
            CompareAndConditionals();
        }
        static void Strings()
        {
            //1.Strings
            //a
            string stringA = "I’m in Game 1377: Scripting for Game Designers";
            //b
            Console.WriteLine(stringA);
            //c
            Console.WriteLine(stringA.ToUpper());
            //d
            Console.WriteLine(stringA.ToLower());
            //e         Will use writeline for clarity, although from here all should be write and not writeline
            //Unclear if directions wanted us to start counting from 0 or 1 to reach letter 8
            Console.WriteLine(stringA.Substring(7));
            //f         4 is used here as letters 8-11 are quantity of 4
            Console.WriteLine(stringA.Substring(7, 4));
            //g
            Console.WriteLine(stringA.Substring(7, 1));
            //End Strings
        }
        static void Arithmetic()
        {
            //2.Arithmetic  
            Console.WriteLine("Please enter a whole number and press enter. Twice.");
            //a
            int intInput1;
            int intInput2;
            //b
            intInput1 = Convert.ToInt32(Console.ReadLine());
            intInput2 = Convert.ToInt32(Console.ReadLine());
            //c + d     adding "labels" and write line for clarity though not technically asked.
            Console.WriteLine("Sum: " + (intInput1 + intInput2));
            Console.WriteLine("Difference: " + (intInput2 - intInput1));
            Console.WriteLine("Product: " + (intInput1 * intInput2));
            //e         Converting inputs to floats/singles before mathing the math.
            Console.WriteLine("Quotient: " + (Convert.ToSingle(intInput1) / Convert.ToSingle(intInput2)));
            Console.WriteLine("Remainder: " + (intInput1 % intInput2));
            //End Arithmetic
        }
        static void Assignment()
        {
            //3.Assignment
            Console.WriteLine("Please enter a number and press enter. Twice.");
            //a
            float floatInput1;
            float floatInput2;
            //b
            floatInput1 = Convert.ToSingle(Console.ReadLine());
            floatInput2 = Convert.ToSingle(Console.ReadLine());
            //c         WriteLines were not asked for, however they do help check the code works.
            floatInput2 = (floatInput2 + floatInput1);
            Console.WriteLine("Check Add: " + floatInput2);
            //d
            floatInput2 = (floatInput2 - floatInput1);
            Console.WriteLine("Check Sub: " + floatInput2);
            //e
            floatInput2 = (floatInput1 * floatInput2);
            Console.WriteLine("Check Multi: " + floatInput2);
            //f
            floatInput2 = (floatInput2 / floatInput1);
            Console.WriteLine("Check Div: " + floatInput2);
            //End Assignment
        }
        static void CompareAndConditionals()
        {
            //4.Compare and Conditionals
            Console.WriteLine("Please enter a whole number and press enter. Twice.");
            //a
            int? intInput1;
            int? intInput2;
            //b
            intInput1 = Convert.ToInt32(Console.ReadLine());
            intInput2 = Convert.ToInt32(Console.ReadLine());
            //c
            if (intInput1 == intInput2)
            {
                Console.WriteLine("The inputs are equal.");
            }
            else if (intInput1 > intInput2)
            {
                Console.WriteLine(intInput1 + " is greater than " + intInput2);
            }
            else
            {
                Console.WriteLine(intInput2 + " is greater than " + intInput1);
            }
            //End Compare and Conditionals
        }
    }
}
