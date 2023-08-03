using EmployeeManagementApp.Extensions;
using EmployeeManagementApp.Models.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagementApp.Components.ManageForm;

[CascadingTypeParameter(nameof(FItem))]
public partial class AssetFormBlock<FItem> : ComponentBase, IDisposable
    where FItem : class, IClearableModel, new()
{
    [CascadingParameter]
    public FItem? ModelToAdd { get; set; }
    [Parameter]
    public IFluentColumn FormColumnSize { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = string.Empty;
    [Parameter]
    public EventCallback<FItem> OnItemAdd { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [CascadingParameter]
    public AssetForm<FItem>? Form { get; set; }

    [Inject]
    private IServiceProvider serviceProvider { get; set; }
    public bool formSuccess { get; set; } = false;

    private IValidator<FItem>? formValidator;

    private List<AssetFormBlockField<FItem>> FormBlockFields = new List<AssetFormBlockField<FItem>>();

    public void AddField(AssetFormBlockField<FItem> field)
    {
        FormBlockFields.Add(field);
    }
    public async Task OnFormFieldChanged()
    {
        formSuccess = false;

        if (formValidator is not null)
        {
            if (ModelToAdd is not null)
            {
                ValidationResult success = (await formValidator.ValidateAsync(ModelToAdd));
                if (success.IsValid)
                {
                    formSuccess = true;
                }
            }
        }
        StateHasChanged();
    }
    protected async Task OnAddItem(MouseEventArgs args)
    {
        if (formValidator is not null)
        {
            if (ModelToAdd is not null)
            {
                ValidationResult success = (await formValidator.ValidateAsync(ModelToAdd));
                if (success.IsValid)
                {
                    await OnItemAdd.InvokeAsync(ModelToAdd);

                    ClearForm();
                }
            }
        }
    }
    protected void ClearForm()
    {
        ModelToAdd?.Clear();

        foreach (var field in FormBlockFields)
        {
            field?.ModelChanged();
        }
        StateHasChanged();
    }
    protected override async Task OnInitializedAsync()
    {
        formValidator = serviceProvider.TryGetValidatorForModel<FItem>();

        await base.OnInitializedAsync();
    }

    public void Dispose()
    {
        FormBlockFields.Clear();
    }
}
