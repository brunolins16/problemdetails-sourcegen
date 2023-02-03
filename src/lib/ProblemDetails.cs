namespace Lib;

using System.Text.Json.Serialization;

public class ProblemDetails
{
    [JsonExtensionData]
    [JsonInclude]
    public IDictionary<string,object> MyProperty { get; } = new Dictionary<string,object>();
}