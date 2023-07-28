using System;

namespace Variable_ops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what type of data type operations u need? in the below");
            Console.WriteLine("1 for int, 2 for float,3 for string,");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("please enter two int vars");
                int input1, input2, output;
                if (int.TryParse(Console.ReadLine(), out input1) && int.TryParse(Console.ReadLine(), out input2))
                {
                    output = input1 + input2;
                    Console.WriteLine("addition is: " + output);
                    output = input1 - input2;
                    Console.WriteLine("subtraction is: " + output);
                    try
                    {
                        // to enable flag for overflow case
                        checked
                        {
                            output = input1 * input2;
                            Console.WriteLine("multiplication is: " + output);
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("multiplication overflow is: " + ex.Message);
                    }

                    try
                    {
                        output = input1 / input2;
                        Console.WriteLine("division is: " + output);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("division by zero is: " + ex.Message);
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("sorry invalid inputs \n");
                }

            }
            else if (type == 2)
            {
                Console.WriteLine("please enter two double vars");
                double input1, input2, output;
                if (double.TryParse(Console.ReadLine(), out input1) && double.TryParse(Console.ReadLine(), out input2))
                {
                    output = input1 + input2;
                    Console.WriteLine("addition is: " + output);
                    output = input1 - input2;
                    Console.WriteLine("subtraction is: " + output);

                    try
                    {
                        output = input1 / input2;
                        Console.WriteLine("division is: " + output);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("division by zero is: " + ex.Message);
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("sorry invalid inputs \n");
                }
            }
            else if (type == 3)
            {
                Console.WriteLine("please enter two string vars");
                string input1, input2, output;
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
                output = input1 + input2;
                Console.WriteLine("concatination is: "+output);

            }
            else
            {
                Console.WriteLine("sorry invalid inputs \n");

            }

        }
        
    }
    
}