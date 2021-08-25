using System;

namespace ConverterApp
{
    public class CurrencyConverter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }
        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public double ConvertToUsd(double value)
        {
            return Math.Round(value / USD,2);
        }
 
        public double ConvertToEur(double value)
        {
            return Math.Round(value / EUR,2);
        }
 
        public double ConvertToRub(double value)
        {
            return Math.Round(value / RUB,2);
        }
 
        public double ConvertFromUsd(double value)
        {
            return Math.Round(USD * value,2);
        }
 
        public double ConvertFromEur(double value)
        {
            return Math.Round(EUR * value,2);
        }
 
        public double ConvertFromRub(double value)
        {
            return Math.Round(RUB * value,2);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new CurrencyConverter(11.34, 13.60, 0.156);
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать в сомони");
            Console.WriteLine("2: Конвертировать из сомони");
 
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }
            Console.WriteLine("Выполнено");
        }
        private static void ConvertTo(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать из USD");
            Console.WriteLine("2: Конвертировать из EUR");
            Console.WriteLine("3: Конвертировать из RUB");
            var option = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            var input = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }
        private static void ConvertFrom(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать в USD");
            Console.WriteLine("2: Конвертировать в EUR");
            Console.WriteLine("3: Конвертировать в RUB");
            var option = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            var input = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }
        }
    }
}