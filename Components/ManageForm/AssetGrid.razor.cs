using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageForm;

public partial class AssetGrid<GItem> : ComponentBase
    where GItem : class
{
    [Parameter]
    public IFluentColumn GridColumnSize { get; set; }
    [Parameter]
    public string Title { get; set; } = string.Empty;
    [Parameter]
    public IEnumerable<GItem> Elements { get; set; } = new List<GItem>();
    [Parameter]
    public Func<GItem, string, bool> FilterFunc { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }
    public List<AssetGridColumn<GItem>> Columns { get; set; } = new List<AssetGridColumn<GItem>>();
    public DataGrid<GItem> Grid { get; set; }

    private GItem selectedItem = null;

    public String SearchString = string.Empty;
    private bool OnModelFilter(GItem model)
    {
        if (FilterFunc is not null)
        {
            return FilterFunc(model, SearchString);
        }
        return true;
    }
    private async Task OnGridSearchChanged(string searchString)
    {
        SearchString = searchString;

        await Grid.Reload();
        
        StateHasChanged();
    }
}
