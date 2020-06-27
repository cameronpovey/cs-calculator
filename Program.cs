using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //set varibles
            bool exit = false;
            bool fneg = false;
            int total = 0;
            int pass = 0;
            int count = 1;
            string c = "";

            //setup lists for numbers and functions
            List<int> nums = new List<int>();
            List<string> func = new List<string>();

            while (exit == false)
            {
                //add number one by one onto nums list
                Console.WriteLine("Enter number " + count + ": ");
                nums.Add(Convert.ToInt32(Console.ReadLine()));

                do
                {
                    fneg = false;
                    Console.WriteLine("(*, /, -, + or =) Enter Function " + count + ": ");
                    c = Console.ReadLine();
                    

                    if (c != "*" && c != "/" && c != "-" && c != "+" && c != "=")
                    {
                        Console.WriteLine("Enter a valid function - *, /, -, + or =");
                        fneg = true;
                    }
                    else if (count == 1 && c == "=")
                    {
                        Console.WriteLine("Enter a valid sum with atleast one function.");
                        fneg = true;
                    }
                    else if (c == "=")
                    {
                        pass = -1;
                        foreach (int x in nums)
                        {
                            if (pass == -1) { total = x; }
                            else if (func[pass] == "*") { total *= x; }
                            else if (func[pass] == "/") { total /= x; }
                            else if (func[pass] == "-") { total -= x; }
                            else if (func[pass] == "+") { total += x; }
                            pass++;
                        }
                        Console.WriteLine(total);
                        exit = true;
                    }
                }
                while (fneg == true);

                func.Add(c);

                count++;
            }
        }
    }
}
