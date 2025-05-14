
namespace FirstTask
{
    internal class Program
    {

        internal static bool DFA(string Stringinput)
        {
            if (Stringinput == "") return false;

            int current_state = 0;
            foreach (var symbol in Stringinput)
            {
                if (symbol != '0' && symbol != '1')
                    return false;

                if (current_state == 0)
                {
                    if (symbol == '0') current_state = 0;
                    else if (symbol == '1') current_state = 1;
                }
                else if (current_state == 1)
                {
                    if (symbol == '0') current_state = 2;
                    else if (symbol == '1') current_state = 1;
                }
                else if (current_state == 2)
                {
                    if (symbol == '0') current_state = 0;
                    else if (symbol == '1') current_state = 3;
                }
                else if (current_state == 3)
                {
                    if (symbol == '0' || symbol == '1')
                        current_state = 3;
                }
            }
            return current_state == 3;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Construct a DFA that accepts all binary strings where the substring 101 appears at least once .");
            while (true)
            {
                Console.Write("Please Enter the Binary String: ");
                var BinaryString = Console.ReadLine();
                var result = DFA(BinaryString);
                if (result == true)
                    Console.WriteLine($" \"{BinaryString}\" is Accepted .");
                else
                    Console.WriteLine($" \"{BinaryString}\" is not Accepted .");

                Found:
                Console.WriteLine("You want to continue [y/n] ??");
                var Reply = Console.ReadLine();
                if (Reply == "n") break;
                else if (Reply == "y") continue;
                else
                {
                    Console.WriteLine($"Invalid Option \"{Reply}\".");
                    goto Found;
                }

            }
        }

    }

}

    

 