namespace EmployeeManagementApp.Models;

public class BuildingTableModel
{
    public string BuildingId { get; set; }
    public string BuildingTitle { get; set; }
    public string DateAdded { get; set; }

    public BuildingTableModel()
    {
        BuildingId = string.Empty;
        BuildingTitle = string.Empty;
        DateAdded = string.Empty;
    }
}
