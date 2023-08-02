using EmployeeManagementApp.Components.ManageGrid;

namespace EmployeeManagementApp.Models;

public class BuildingTableModel : IAssetSelectItem<int>
{
    public int Id => BuildingId;
    public string Name => BuildingTitle;
    public int BuildingId { get; set; }
    public string BuildingTitle { get; set; }
    public string DateAdded { get; set; }

    public BuildingTableModel()
    {
        BuildingId = 0;
        BuildingTitle = string.Empty;
        DateAdded = string.Empty;
    }
}
