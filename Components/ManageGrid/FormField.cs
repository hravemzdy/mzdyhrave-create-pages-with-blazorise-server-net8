using Blazorise;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

public class FormField<TGItem, TFItem> : ComponentBase
    where TGItem : class, new()
    where TFItem : class, new()
{
    [Parameter]
    public string Field { get; set; }

    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public bool Validate { get; set; }

    [Parameter]
    public RenderFragment<dynamic> Template { get; set; }

    [CascadingParameter()]
    public ManageAssetForm<TGItem, TFItem> Form { get; set; }
    protected override Task OnInitializedAsync()
    {
        Form.AddField(this);
        return base.OnInitializedAsync();
    }
}
