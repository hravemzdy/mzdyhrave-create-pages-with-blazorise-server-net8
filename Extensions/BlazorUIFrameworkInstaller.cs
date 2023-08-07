using Blazorise.FluentValidation;
using FluentValidation;
using EmployeeManagementApp;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlazorUIFrameworkInstaller
{
    public static IServiceCollection AddBlazoriseServices(this IServiceCollection services)
    {
        services.AddBlazorise();
        services.AddBulmaProviders();
        services.AddFontAwesomeIcons();
        services.AddBlazoriseFluentValidation();

        services.AddValidatorsFromAssembly(typeof(App).Assembly);

        return services;
    }
}
