namespace Task2_Converter
{
    class Converter
    {
        public static double Rate { get; set; }

        public Converter(double rate) =>
            Rate = rate;

        public double ConvertCurrency(double amount) =>
            amount * Rate;
    }
}
