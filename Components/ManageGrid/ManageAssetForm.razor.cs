using Blazorise;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

[CascadingTypeParameter(nameof(GItem))]
[CascadingTypeParameter(nameof(FItem))]
public partial class ManageAssetForm<GItem, FItem> : ComponentBase
    where GItem : class, new()
    where FItem : class, new()
{
    [Parameter]
    public IFluentColumn FormColumnSize { get; set; }
    [Parameter]
    public IFluentSpacing FormPadding { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = string.Empty;
    [Parameter]
    public List<FormField<GItem, FItem>> Fields { get; set; } = new List<FormField<GItem, FItem>>();
    [Parameter]
    public DataGrid<GItem> Grid { get; set; }
    [Parameter]
    public RenderFragment AssetFormFields { get; set; }

    private bool formSuccess = false;

    Validations formValidations;

    FItem itemToAdd = new();

    private async Task OnModelChanged()
    {
        if (await formValidations.ValidateAll())
        {
            formSuccess = true;
        }
    }
    protected async Task OnAddItem()
    {
        if (await formValidations.ValidateAll())
        {
            // the item is validated and we can proceed with the saving process
        }
    }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }
    protected override void OnParametersSet()
    {
        if (FormPadding == null)
        {
            FormPadding = Padding.IsAuto;
        }
    }
    public void AddField(FormField<GItem, FItem> field)
    {
        Fields.Add(field);
    }
}
