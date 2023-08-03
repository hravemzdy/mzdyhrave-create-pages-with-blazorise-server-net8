using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace EmployeeManagementApp.Components.ManageForm;

[CascadingTypeParameter(nameof(GItem))]
public partial class AssetGridColumn<GItem> : ComponentBase
    where GItem : class
{
    [Parameter]
    public string Caption { get; set; } = string.Empty;
    [Parameter]
    public string Field { get; set; } = string.Empty;
    [Parameter]
    public bool Sortable { get; set; } = false;
    [Parameter]
    public Expression<Func<GItem, string>> ModelExpression { get; set; } = default!;
    [CascadingParameter]
    public AssetGrid<GItem>? Grid { get; set; }

    protected override Task OnInitializedAsync()
    {
        if (Grid != null)
        {
            Grid.Columns.Add(this);
        }
        return base.OnInitializedAsync();
    }
}
