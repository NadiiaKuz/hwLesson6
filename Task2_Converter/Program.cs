namespace Task2_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input rate UAH to USD: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input amount UAH: ");
            double anount = Convert.ToDouble(Console.ReadLine());

            Converter converter = new Converter(rate);
            double rounded = Math.Round(converter.ConvertCurrency(anount), 2);

            Console.WriteLine($"You will get {rounded} USD");

            Console.ReadLine();
        }
    }
}