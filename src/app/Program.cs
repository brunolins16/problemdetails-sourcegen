
using Lib;
using System.Text.Json;
using System.Text.Json.Serialization;


var json = """{ "test": "test"}""";

var obj = JsonSerializer.Deserialize<ProblemDetails>(json, SampleContext.Default.ProblemDetails);

Console.WriteLine(obj);


[JsonSerializable(typeof(ProblemDetails))]
public partial class SampleContext : JsonSerializerContext
{

}