namespace ConversorTemperatura.App;
public class ConversorTemperaturaClass
{
    public double ParaFahrenheit(double celsius) => celsius * 9 / 5 + 32;
    public double ParaCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
}