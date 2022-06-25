using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using System.Text.Json.Serialization;

namespace aotsamples;

public class Function
{
    private static async Task Main()
    {
        Func<string, ILambdaContext, string> handler = FunctionHandler;
        await LambdaBootstrapBuilder.Create(handler, new DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }

    public static string FunctionHandler(string input, ILambdaContext context)
    {
        var result = 0;
        var arr = input.ToCharArray();

        foreach (var ch in arr)
        {
            if (ch == '(')
            {
                result++;
            }
            else
            {
                result--;
            }
        }

        return result.ToString();
    }
}