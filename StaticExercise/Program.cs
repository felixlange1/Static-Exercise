namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit temperature to convert to Celsius");
            double tempF = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.FahrenheittoCelsius(tempF));
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter Celsius temperature to convert to Fahrenheit");
            double tempC = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.CelsiustoFahrenheit(tempC));
        }
    }
}
