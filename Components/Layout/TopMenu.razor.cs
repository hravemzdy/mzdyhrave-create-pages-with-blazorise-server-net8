using Blazorise.Localization;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.Layout;

public partial class TopMenu
{
    protected override async Task OnInitializedAsync()
    {
        await SelectCulture("en-US");

        await base.OnInitializedAsync();
    }

    Task SelectCulture(string name)
    {
        LocalizationService!.ChangeLanguage(name);

        return Task.CompletedTask;
    }

    [Parameter] public EventCallback<bool> ThemeEnabledChanged { get; set; }

    [Parameter] public EventCallback<bool> ThemeGradientChanged { get; set; }

    [Parameter] public EventCallback<bool> ThemeRoundedChanged { get; set; }

    [Parameter] public EventCallback<string> ThemeColorChanged { get; set; }

    [Inject] protected ITextLocalizerService? LocalizationService { get; set; }

    [CascadingParameter] protected Theme? Theme { get; set; }
}
