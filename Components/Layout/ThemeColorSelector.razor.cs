using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.Layout;

public partial class ThemeColorSelector
{
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    Task OnThemeColorSelect(string value)
    {
        Value = value;
        return ValueChanged.InvokeAsync(value);
    }
}
