using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

public class FormField<TGItem, TFItem> : ComponentBase
    where TGItem : class, new()
    where TFItem : class, IAddTableModel<TGItem, TFItem>, new()
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
    public Func<TFItem, string> GetModelValue { get; set; }
    [Parameter]
    public Func<TFItem, string, bool> SetModelValue { get; set; }
    [Parameter]
    public EventCallback<string> CurrentValueChanged { get; set; }
    [CascadingParameter()]
    public ManageAssetForm<TGItem, TFItem> Form { get; set; }
    public TFItem FormModel { get; set; }
    public string CurrentValue { get; set; } = string.Empty;

    public async Task FormValueChanged(string val)
    {
        CurrentValue = val;

        if (FormModel is not null)
        {
            SetModelValue(FormModel, CurrentValue);
        }
        await CurrentValueChanged.InvokeAsync(val);

        await Form.OnModelChanged();
    }
    protected override Task OnInitializedAsync()
    {
        FormModel = Form.ModelToAdd;
        if (FormModel is not null)
        {
           CurrentValue = GetModelValue(FormModel);
        }
        Form.AddField(this);
        return base.OnInitializedAsync();
    }
}
