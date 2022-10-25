namespace TempService
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] tempCel = { 32.5, 54.8, 39.4 };

            foreach (var t in tempCel)
            {
                Console.WriteLine($"Celcius: {t} converted to Farenheit: {Temp.CTF(t)}");
            }

            double[] tempFar = { 45.5, 79.8, 54.4 };

            foreach (var t in tempFar)
            {
                Console.WriteLine($"Farenheit: {t} converted to Celcius: {Temp.FTC(t)}");
            }

        }
    }
}