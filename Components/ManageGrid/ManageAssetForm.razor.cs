using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagementApp.Components.ManageGrid;

[CascadingTypeParameter(nameof(GItem))]
[CascadingTypeParameter(nameof(FItem))]
public partial class ManageAssetForm<GItem, FItem> : ComponentBase
    where GItem : class, new()
    where FItem : class, IAddTableModel<GItem, FItem>, new()
{
    [Inject]
    private IServiceProvider serviceProvider { get; set; }

    [Parameter]
    public IFluentColumn FormColumnSize { get; set; }
    [Parameter]
    public IFluentSpacing FormPadding { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = string.Empty;
    [Parameter]
    public List<FormField<GItem, FItem>> Fields { get; set; } = new List<FormField<GItem, FItem>>();
    [Parameter]
    public RenderFragment AssetFormFields { get; set; }
    [Parameter]
    public EventCallback<FItem> OnItemAdd { get; set; }

    private bool formSuccess = false;

    public FItem ModelToAdd { get; set; } = new();

    private IValidator<FItem>? formValidator;
    public async Task OnModelChanged()
    {
        if (formValidator is not null)
        {
            ValidationResult success = (await formValidator.ValidateAsync(ModelToAdd));
            if (success.IsValid)
            {
                formSuccess = true;
            }
            else
            { 
                formSuccess = false; 
            }
        }
        StateHasChanged();
    }
    protected async Task OnAddItem(MouseEventArgs args)
    {
        if (formValidator is not null)
        {
            ValidationResult success = (await formValidator.ValidateAsync(ModelToAdd));
            if (success.IsValid)
            {
                await OnItemAdd.InvokeAsync(ModelToAdd);
            }
        }
    }
    protected override async Task OnInitializedAsync()
    {
        formValidator = TryGetValidatorForObjectType(typeof(FItem));

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
    public void ClearAddFields()
    {
        foreach (var item in Fields)
        {
            item.CurrentValue = string.Empty;   
        }
        formSuccess = false;
    }
    private IValidator<FItem>? TryGetValidatorForObjectType(Type modelType)
    {
        Type serviceType = typeof(IValidator<>)!.MakeGenericType(modelType);
        return serviceProvider.GetRequiredService(serviceType) as IValidator<FItem>;
    }
}
