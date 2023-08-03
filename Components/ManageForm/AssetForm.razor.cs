using EmployeeManagementApp.Models.Interfaces;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageForm;

public partial class AssetForm<FItem> : ComponentBase
    where FItem : class, IClearableModel, new()
{
    [Parameter]
    public IFluentSpacing FormPadding { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public FItem ModelToAdd { get; set; } = new();

}
