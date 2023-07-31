using Blazorise.FluentValidation;
using FluentValidation;

namespace EmployeeManagementApp.Extensions;
public static class BlazoriseInstaller
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
