namespace StaticExercise;

public class TempConverter
{
    public static double FahrenheittoCelsius(double temp)
    {
        return (temp - 32) * 5 / 9;
    }

    public static double CelsiustoFahrenheit(double temp)
    {
        return temp * 9 / 5 + 32;
    }
}