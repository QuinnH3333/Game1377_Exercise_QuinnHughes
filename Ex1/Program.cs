namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args) 
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
            Console.WriteLine(stringA.Substring(7,4));
            //g
            Console.WriteLine(stringA.Substring(7,1));
                    //End Strings

                    //2.Arrithmitic  
            Console.WriteLine("Please enter a whole number and press enter. Twice.");
            //a
            int? intImput1;
            int? intImput2;
            //b
            intImput1 = Convert.ToInt32(Console.ReadLine());
            intImput2 = Convert.ToInt32(Console.ReadLine());
            //c + d     adding "lables" and write line for clarity though not technically asked.
            Console.WriteLine("Sum: " + (intImput1 + intImput2));
            Console.WriteLine("Difference: " + (intImput2 - intImput1));
            Console.WriteLine("Product: " + (intImput1 * intImput2));
            //e         Converting imputs to floats/singles before mathing the math
            Console.WriteLine("Quotient: "+ (Convert.ToSingle(intImput1)/Convert.ToSingle(intImput2)));
                    //End Arrithmitic

        }
        
    }
}
