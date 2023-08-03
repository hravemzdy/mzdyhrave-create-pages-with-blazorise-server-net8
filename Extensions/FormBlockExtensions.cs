using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementApp.Extensions;

public static class FormBlockExtensions
{
    public static IValidator<FItem>? TryGetValidatorForModel<FItem>(this IServiceProvider serviceProvider)
    {
        Type modelType = typeof(FItem);
        Type modelValidatorType = typeof(IValidator<>)!.MakeGenericType(modelType);
        return serviceProvider.GetRequiredService(modelValidatorType) as IValidator<FItem>;
    }

}
