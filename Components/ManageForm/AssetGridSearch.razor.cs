using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageForm;

[CascadingTypeParameter(nameof(GItem))]
public partial class AssetGridSearch<GItem> : ComponentBase
    where GItem : class
{
    [Parameter]
    public string Title { get; set; } = string.Empty;
    [Parameter]
    public EventCallback<string> SearchStringChanged { get; set; }
    [CascadingParameter]
    public AssetGrid<GItem>? SearchGrid { get; set; }
    public string SearchString { get; set; } = string.Empty;
    private async Task OnFilterValueChanged(string e)
    {
        SearchString = e;

        if (SearchGrid != null)
        {
            SearchGrid.SearchString = SearchString;

            await SearchStringChanged.InvokeAsync(SearchString);
        }
    }
    protected override void OnParametersSet()
    {
    }
}
