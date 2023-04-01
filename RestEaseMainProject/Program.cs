using RestEase;

var publishService = RestClient.For<IPublishService>("https://localhost:7015");
var weather = await publishService.GetWeather();

[SerializationMethods(Query = QuerySerializationMethod.Serialized, Body = BodySerializationMethod.Serialized)]
public interface IPublishService
{
    [AllowAnyStatusCode]
    [Get("WeatherForecast")]
    Task<IEnumerable<WeatherForecast>> GetWeather();
}

public class WeatherForecast 
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public int TemperatureF { get; set; }
    public string? Summary { get; set; }
}