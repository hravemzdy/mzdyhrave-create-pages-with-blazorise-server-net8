using Microsoft.AspNetCore.Components;

namespace EmployeeManagementApp.Components.ManageGrid;

[CascadingTypeParameter(nameof(TItem))]
[CascadingTypeParameter(nameof(CItem))]
public partial class ManageAssetSelect<TItem, CItem> : ComponentBase
    where TItem : IAssetSelectItem<CItem>
{
    [Parameter]
    public IEnumerable<TItem> Elements { get; set; } = new List<TItem>();
    [Parameter]
    public string SelectLabel { get; set; } = string.Empty;
    [Parameter]
    public string SelectedLabel { get; set; } = string.Empty;
    [Parameter]
    public CItem DefaultValue { get; set; } = default;
    [Parameter]
    public CItem CurrentValue { get; set; } = default;
    [Parameter]
    public EventCallback<CItem> CurrentValueChanged { get; set; }
    void ValidateValue(ValidatorEventArgs e)
    {
        bool deafultSelection = CurrentValue.Equals(DefaultValue);
        e.Status = deafultSelection==false ? ValidationStatus.Success : ValidationStatus.Error;
    }
    public void OnChangedAfter()
    {
        CItem value = CurrentValue;

        CurrentValueChanged.InvokeAsync(value);
    }
    private string CurrentName { get => CurrentElementName(); }

    private string CurrentElementName()
    {
        TItem? currentItem = Elements.FirstOrDefault(x => (x.Id.Equals(CurrentValue)));
        if (currentItem == null)
        {
            return string.Empty;
        }
        return currentItem.Name;
    }
    private TextColor CurrentColor { get => (CurrentValue.Equals(DefaultValue) ? TextColor.Danger : TextColor.Success); }
}
