namespace EmployeeManagementApp.Extensions;
public static class BlazoriseInstaller
{
    public static IServiceCollection AddBlazoriseServices(this IServiceCollection services)
    {
        services.AddBlazorise();
        services.AddBulmaProviders();
        services.AddFontAwesomeIcons();

        return services;
    }
}
