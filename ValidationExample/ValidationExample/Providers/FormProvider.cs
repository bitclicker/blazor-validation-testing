using ValidationExample.Client.Models;
using ValidationExample.Client.Providers;

namespace ValidationExample.Providers;

public class FormProvider : IFormProvider
{
    readonly ILogger<FormProvider> _logger;

    public FormProvider(ILogger<FormProvider> logger)
    {
        _logger = logger;
    }

    public Task SubmitFormAsync(FormModel formModel)
    {
        _logger.LogInformation("Form submitted: {FormModel}", formModel);
        return Task.CompletedTask;
    }
}