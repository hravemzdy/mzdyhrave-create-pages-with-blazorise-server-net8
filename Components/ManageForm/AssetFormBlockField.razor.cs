using EmployeeManagementApp.Extensions;
using EmployeeManagementApp.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace EmployeeManagementApp.Components.ManageForm;

[CascadingTypeParameter(nameof(FItem))]
public partial class AssetFormBlockField<FItem> : ComponentBase
    where FItem : class, IClearableModel, new()
{
    [Parameter]
    public string Label { get; set; }
    [Parameter]
    public string FeedbackNone { get; set; }
    [Parameter]
    public string FeedbackGood { get; set; }
    [Parameter]
    public string FeedbackError { get; set; }
    [Parameter]
    public bool Validate { get; set; }
    [Parameter]
    public RenderFragment<dynamic> Template { get; set; }
    [Parameter]
    public EventCallback<string> CurrentValueChanged { get; set; }
    [Parameter]
    public Expression<Func<FItem, string>> ModelExpression { get; set; } = default!;

    [CascadingParameter]
    public AssetForm<FItem>? Form { get; set; }

    [CascadingParameter]
    public AssetFormBlock<FItem>? FormBlock { get; set; }

    [CascadingParameter]
    public FItem? FormModel { get; set; }
    public string CurrentValue { get; set; } = string.Empty;
    protected override async Task OnInitializedAsync()
    {
        if (FormBlock is not null)
        {
            FormBlock.AddField(this);
        }
        if (FormModel is not null)
        {
            CurrentValue = FormModel.GetPropertyValue(ModelExpression) ?? string.Empty;
        }
        await base.OnInitializedAsync();
    }
    public async Task FormValueChanged(string val)
    {
        CurrentValue = val;

        if (FormModel is not null)
        {
            FormModel.SetPropertyValue(ModelExpression, CurrentValue);

            if (FormBlock is not null)
            {
                await FormBlock.OnFormFieldChanged();
            }
        }
        await CurrentValueChanged.InvokeAsync(val);
    }
    public Task ModelChanged()
    {
        if (FormModel is not null)
        {
            CurrentValue = FormModel.GetPropertyValue(ModelExpression) ?? string.Empty;
        }
        return Task.CompletedTask;
    }
}
