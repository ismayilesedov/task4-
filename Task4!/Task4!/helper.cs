namespace Task4_
{
    internal class helper
    {
        internal static string stringChecker()
        {
            l1:
            string input=Console.ReadLine();
            if (int.TryParse(input,out int a))
            {
                Console.WriteLine("Duzgun daxil edin");
                goto l1;
            }
            return input;
        }
    }
}
