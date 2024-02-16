using System.Runtime.CompilerServices;
using System.Text;

namespace Console_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Procentage");
                Console.WriteLine("6. EXIT");

                Console.Write("Select operation (1/2/3/4/5/6): ");

                string operationNum = Console.ReadLine();
                bool operationNumRes = int.TryParse(operationNum, out var number);
                if (operationNumRes == true)
                {
                    int num = int.Parse(operationNum);
                    if (num == 1)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Additional operation:");
                        Console.ResetColor();
                        Console.WriteLine("Please choose first number");
                        string firstAdd = Console.ReadLine();
                        int firAdd = int.Parse(firstAdd);
                        Console.WriteLine("Additional operation: " + firAdd + " + " + "_ choose second number");
                        string secondAdd = Console.ReadLine();
                        int secAdd = int.Parse(secondAdd);
                        int summAdd = firAdd + secAdd;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Additional operation: " + firAdd + " + " + secAdd + " = " + summAdd);
                        Console.ResetColor();
                        Console.WriteLine();
                        continue;
                    }

                    if (num == 2)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Substraction operation:");
                        Console.ResetColor();
                        Console.WriteLine("Please choose first number");
                        string firstSub = Console.ReadLine();
                        int firSub = int.Parse(firstSub);
                        Console.WriteLine("Substraction operation: " + firSub + " - " + "_ choose second number");
                        string secondSub = Console.ReadLine();
                        int secSub = int.Parse(secondSub);
                        int summSub = firSub - secSub;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Substraction operation: " + firSub + " - " + secSub + " = " + summSub);
                        Console.ResetColor();
                        Console.WriteLine();
                        continue;
                    }

                    if (num == 3)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Multiplication operation:");
                        Console.ResetColor();
                        Console.WriteLine("Please choose first number");
                        string firstMult = Console.ReadLine();
                        int firMult = int.Parse(firstMult);
                        Console.WriteLine("Multiplication operation: " + firMult + " x " + "_ choose second number");
                        string secondMult = Console.ReadLine();
                        int secMult = int.Parse(secondMult);
                        int summMult = firMult * secMult;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Multiplication operation: " + firMult + " x " + secMult + " = " + summMult);
                        Console.ResetColor();
                        Console.WriteLine();
                        continue;
                    }

                    if (num == 4)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Division operation:");
                        Console.ResetColor();
                        Console.WriteLine("Please choose first number");
                        string firstDiv = Console.ReadLine();
                        var firDiv = int.Parse(firstDiv);
                        Console.WriteLine("Division operation: " + firDiv + " / " + "_ choose second number");
                        string secondDiv = Console.ReadLine();
                        var secDiv = int.Parse(secondDiv);
                        //bool secDivs = true;
                        
                        while (secDiv == 0) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No division! Choose another number.");
                            Console.ResetColor();
                            secondDiv = Console.ReadLine();
                            secDiv = int.Parse(secondDiv);
                        }

                        if (secDiv != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Division operation: " + firDiv + " / " + secDiv + " = " + (float)firDiv / secDiv);
                            Console.ResetColor();
                            Console.WriteLine();
                            continue;
                        }
                    }

                    if (num == 5)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Prosentage operation:");
                        Console.ResetColor();
                        Console.WriteLine("Please choose first number");
                        string firstProcent = Console.ReadLine();
                        bool res1Procent = int.TryParse(firstProcent, out int a);
                        //пока результат парсинга ложный, выводим сообщение на экран
                        while (!res1Procent)
                        {
                            Console.WriteLine("Please enter correct number, not a letter. Please enter the number");
                            firstProcent = Console.ReadLine();
                            res1Procent = int.TryParse(firstProcent, out a);
                        }
                        if (res1Procent == true)
                        {
                            Console.WriteLine("Prosentage operation: choose how much procents from the number " + a);
                            string secondAdd2 = Console.ReadLine();
                            int secAdd2 = int.Parse(secondAdd2);
                            int procents = a * secAdd2 / 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Prosentage operation: " + a + " * " + secAdd2 + " % = " + procents);
                            Console.ResetColor();
                            Console.WriteLine();
                            continue;
                        }
                    }

                    if (num == 6)
                    {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Exit complited!");
                            Console.ResetColor();
                    
                    }

                    
                    break;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose number from 1 to 6");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
            }
        }
    }
}
