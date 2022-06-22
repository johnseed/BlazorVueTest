using Dapr.Client;
using Grpc.Net.Client;
using System.Text.Json.Serialization;

public static class InterpSDK
{
    public async static Task<InterpResult> Interp(List<int> lon, List<int> lat, List<double> var)
    {
        var daprClient = new DaprClientBuilder().UseGrpcChannelOptions(new GrpcChannelOptions()
        {
            MaxReceiveMessageSize = 2047 * 1024 * 1024,
            MaxSendMessageSize = 2047 * 1024 * 1024
        }).Build();
        string request = "interp";
        var data = new
        {
            lon = lon,
            lat = lat,
            var = var
        };
        InterpResult? result = await daprClient.InvokeMethodAsync<object, InterpResult>("gda-algorithm-interp", request, data);
        return result;
    }
}

public class InterpResult
{
    [JsonPropertyName("lon_grid")]
    public List<List<double>> LonGrid { get; set; }

    [JsonPropertyName("lat_grid")]
    public List<List<double>> LatGrid { get; set; }

    [JsonPropertyName("tm_grid")]
    public List<List<double>> TmGrid { get; set; }
}