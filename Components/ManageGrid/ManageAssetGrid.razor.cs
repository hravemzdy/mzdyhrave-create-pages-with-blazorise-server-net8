using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

[CascadingTypeParameter(nameof(GItem))]
public partial class ManageAssetGrid<GItem> : ComponentBase
    where GItem : class, new()
{
    [Parameter]
    public IFluentColumn GridColumnSize { get; set; }
    [Parameter]
    public string Title { get; set; } = string.Empty;
    [Parameter]
    public List<GridColumn<GItem>> Columns { get; set; } = new List<GridColumn<GItem>>();
    [Parameter]
    public RenderFragment AssetGridColumns { get; set; }
    [Parameter]
    public IEnumerable<GItem> Elements { get; set; } = new List<GItem>();
    [Parameter]
    public Func<GItem, string, bool> FilterFunc { get; set; }

    public DataGrid<GItem> Grid { get; set; }

    private GItem selectedItem = null;

    private HashSet<GItem> selectedItems = new HashSet<GItem>();


    private string searchString = string.Empty;

    private bool OnModelFilter(GItem model)
    {
        if (FilterFunc is not null)
        {
            return FilterFunc(model, searchString);
        }
        return true;
    }

    private Task OnFilterValueChanged(string e)
    {
        searchString = e;

        return Grid.Reload();
    }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }
    public void AddColumn(GridColumn<GItem> column)
    { 
        Columns.Add(column); 
    }

}
