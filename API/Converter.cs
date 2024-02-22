namespace API
{
    public class Converter
    {
        public static int ToCelsius(ETemperatureUnit @from, double value) => @from switch
        {
            // From Fahrenheit to Celsius = 5/9 * (F – 32)
            ETemperatureUnit.Fahrenheit => (int)(5 * (value - 32) / 9),
            // From Kelvin to Celsius = K – 273
            ETemperatureUnit.Kelvin => (int)value - 273,
            _ => (int)value,
        };

        public static int ToFahrenheit(ETemperatureUnit @from, double value) => @from switch
        {
            // From Celsius to Fahrenheit = (C * 1.8) + 32
            ETemperatureUnit.Celsius => (int)((1.8 * value) + 32),
            // From Kelvin to Fahrenheit = (K – 273.15) * 1.8 + 32
            ETemperatureUnit.Kelvin => (int)((value - 273) * 1.8 + 32),
            _ => (int)value
        };

        public static int ToKelvin(ETemperatureUnit @from, double value) => @from switch
        {
            // From Celsius to Kelvin = C + 273
            ETemperatureUnit.Celsius => (int)(value + 273),
            // From Fahrenheit to Kelvin = (F – 32) * 5/9 + 273
            ETemperatureUnit.Fahrenheit => (int)(((value - 32) * 5 / 9) + 273),
            _ => (int)value
        };
    }

    public enum ETemperatureUnit
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }
}