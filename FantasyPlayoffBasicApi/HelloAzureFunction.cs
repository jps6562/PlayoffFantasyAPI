using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FantasyPlayoffBasicApi;

public class HelloAzureFunction
{
    private readonly ILogger<HelloAzureFunction> _logger;

    public HelloAzureFunction(ILogger<HelloAzureFunction> logger)
    {
        _logger = logger;
    }

    [Function("HelloAzureFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = new
        {
            message = "Welcome to John Jr's Azure Functions!"
        };

        return new OkObjectResult(response);
    }
}