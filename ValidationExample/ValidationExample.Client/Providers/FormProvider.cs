using System.Net.Http.Json;
using ValidationExample.Client.Models;

namespace ValidationExample.Client.Providers;

public class FormProvider : IFormProvider
{
    private readonly IHttpClientFactory _clientFactory;

    public FormProvider(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }
    public async Task SubmitFormAsync(FormModel formModel)
    {
        var client = _clientFactory.CreateClient("ValidationExample.Client");
        await client.PostAsJsonAsync("/api/form", formModel);
        Console.WriteLine("Form Submitted Successfully!");
    }
}