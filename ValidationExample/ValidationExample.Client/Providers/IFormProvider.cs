using ValidationExample.Client.Models;

namespace ValidationExample.Client.Providers;

public interface IFormProvider
{
    public Task SubmitFormAsync(FormModel formModel);
}