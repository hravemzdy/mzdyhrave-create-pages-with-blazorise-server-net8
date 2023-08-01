using Blazorise;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

public class GridColumn<TGItem> : ComponentBase
    where TGItem : class, new()
{
    [Parameter]
    public string Field { get; set; }

    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public bool Sortable { get; set; }

    [Parameter]
    public RenderFragment<dynamic> Template { get; set; }
   
    [CascadingParameter()]
    public ManageAssetGrid<TGItem> Grid { get; set; }

    protected override Task OnInitializedAsync()
    {
        Grid.Columns.Add(this);
        return base.OnInitializedAsync();
    }
}
