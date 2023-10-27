namespace UniqueCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter word");
            string inputString = Console.ReadLine();
            Control(inputString);
            if (Control(inputString) == true)
            {
                Console.WriteLine("All Characters are Unique");
            }
            else
            {
                Console.WriteLine("Characters are not Unique");
            }
        }

        private static bool Control(string inputString)
        {
            bool result = true;
            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    if (inputString[j] == inputString[i])
                    {
                        result = false;
                        break;
                    }
                }
                if (result == false)
                {
                    break;
                }
            }
            return result;
        }
    }
}