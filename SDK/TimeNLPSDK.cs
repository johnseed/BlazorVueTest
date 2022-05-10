using Dapr.Client;
using Grpc.Net.Client;

public static class TimeNLPSDK
{
    public async static Task<string> ParseCNTime(string time, int? year = null)
    {
        return (await ParseCNTimeFull(time, year))?[0] ?? string.Empty;
    }

    public async static Task<string[]> ParseCNTimeFull(string time, int? year = null)
    {
        var daprClient = new DaprClientBuilder().UseHttpEndpoint("http://127.0.0.1:3500").UseGrpcChannelOptions(new GrpcChannelOptions()
        {
            MaxReceiveMessageSize = 2047 * 1024 * 1024,
            MaxSendMessageSize = 2047 * 1024 * 1024
        }).Build();
        string request = year is null ? $"ParseTime?phrase={time}" : $"ParseTime?phrase={time}&year={year}";
        var timeResult = await daprClient.InvokeMethodAsync<TimeNLP>(HttpMethod.Get, "nlp-server", request);
        return timeResult.time ?? new[] { string.Empty, string.Empty };
    }

    public class TimeNLP
    {
        public string? Type { get; set; }
        public string? definition { get; set; }
        public string[]? time { get; set; }
    }
}