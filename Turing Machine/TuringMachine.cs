using System;
using System.Collections.Generic;
using System.Security;

namespace TMTask
{
    internal class TuringMachine
    {
        internal List<char> tape;
        internal int HeadPosition;
        internal string currentState;

        internal TuringMachine(string StringValue)
        {
            tape = new List<char> { 'B' };
            tape.AddRange(StringValue.ToCharArray());
            tape.Add('B');

            HeadPosition = 1; 
            currentState = "Q0";
        }

        internal bool Run()
        {
            while (currentState != "Accept" && currentState != "Reject")
            {

                if (HeadPosition >= tape.Count) tape.Add('B');
                else if (HeadPosition < 0)
                {
                    tape.Insert(0, 'B');
                    HeadPosition = 0;
                }

                char currentSymbol = tape[HeadPosition];
                

                if(currentState == "Q0")
                {
                    if (currentSymbol == '0')
                    {
                        HeadPosition++;
                        currentState = "Q0";
                    }
                    else if (currentSymbol == '1')
                    {
                        HeadPosition++;
                        currentState = "Q1";
                    }
                    else if (currentSymbol == 'B') currentState = "Accept";
                    else currentState = "Reject";
                }
                else if(currentState == "Q1")
                {
                    if (currentSymbol == '0')
                    {
                        HeadPosition++;
                        currentState = "Q2";
                    }
                    else if (currentSymbol == '1')
                    {
                        HeadPosition++;
                        currentState = "Q0";
                    }
                    else if (currentSymbol == 'B') currentState = "Reject";
                    else  currentState = "Reject";
                }
                else if(currentState == "Q2")
                {
                    if (currentSymbol == '0')
                    {
                        HeadPosition++;
                        currentState = "Q1";
                    }
                    else if (currentSymbol == '1')
                    {
                        HeadPosition++;
                        currentState = "Q2";
                    }
                    else if (currentSymbol == 'B') currentState = "Reject";
                    else  currentState = "Reject";
                }
            }

            return currentState == "Accept";
        }
        internal static void RunningApp()
        {
            Console.WriteLine("[Turing Machine]:[Binary Numbers Divisible by 3]");
            Console.WriteLine("---------------------------------------------");

            while (true)
            {
                Found:
                    Console.Write("Please Enter a Binary Number (or 'exit' to stop application): ");
                    string BinaryString = Console.ReadLine();

                if (BinaryString.ToLower() == "exit") break;
                else if (BinaryString == "") goto Found;
                
                var check = new TuringMachine(BinaryString);
                bool result = check.Run();
                Console.WriteLine($"The number \"{BinaryString}\" is {(result ? "" : "not ")}divisible by \"3\"\n");
            }
        }
    }
}