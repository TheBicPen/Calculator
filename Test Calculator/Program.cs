﻿using System;



namespace Test_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the variables for the numbers
            decimal decimal1;
            decimal decimal2;

            //declaring the operator used for the current function
            //string operator1;

            bool retry = true;

            while (retry == true)
            {
                Console.WriteLine("Input a number");
                var input1 = Console.ReadLine();
                Decimal.TryParse(input1, out decimal1);


                Console.WriteLine("Input a number");
                var input2 = Console.ReadLine();
                Decimal.TryParse(input2, out decimal2);

                Console.WriteLine("Input an operator");
                var input3 = Console.ReadLine();


                try
                {

                    switch (input3)
                    {
                        case "*":
                            Console.WriteLine(decimal1 + " " + input3 + " " + decimal2 + " = " + (decimal1 * decimal2));
                            break;

                        case "-":
                            Console.WriteLine(decimal1 + " " + input3 + " " + decimal2 + " = " + (decimal1 - decimal2));
                            break;

                        case ":":
                            Console.WriteLine(decimal1 + " " + input3 + " " + decimal2 + " = " + (decimal1 / decimal2));
                            break;

                            //same operator as above
                        case "/":
                            Console.WriteLine(decimal1 + " " + input3 + " " + decimal2 + " = " + (decimal1 / decimal2));
                            break;

                        case "+":
                            Console.WriteLine(decimal1 + " " + input3 + " " + decimal2 + " = " + (decimal1 + decimal2));
                            break;

                
                        case "^manual":
                            int exponentCounter = Decimal.ToInt32(decimal2);
                            decimal output = decimal1;
                            while (exponentCounter != 0)
                            {

                                //currently an inefficient workaround
                                Console.WriteLine(decimal1 + " " + input3 + " " + (decimal2 + 1 - exponentCounter) + " = " + output);
                                output = output * decimal1;

                                if (exponentCounter > 0)
                                { exponentCounter--; }

                                if (exponentCounter < 0)
                                { exponentCounter++; }
                            }

                            break;

                        case "^":
                            Console.WriteLine (decimal1 + " " + input3 + " " + decimal2 + " = " + Math.Pow (Decimal.ToDouble(decimal1) , Decimal.ToDouble(decimal2) ) );
                            break;

                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }

                }

                catch
                {
                    Console.WriteLine("math error");
                    Console.Beep();
                }

                Console.WriteLine("Do another? Input true or false");
                Boolean.TryParse(Console.ReadLine(), out retry);

            }
        }
    }
}
