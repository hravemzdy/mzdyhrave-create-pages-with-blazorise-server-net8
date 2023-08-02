using EmployeeManagementApp.Models;

namespace EmployeeManagementApp.Extensions;

public static class BuildingModelTestException
{
    public static List<BuildingTableModel> TestTableCollection(this List<BuildingTableModel> list)
    {
        var items = new List<BuildingTableModel>()      
        {
            new BuildingTableModel() { BuildingId = 1, BuildingTitle = "Building First", DateAdded = "01.01.2023" },
            new BuildingTableModel() { BuildingId = 2, BuildingTitle = "Building Second", DateAdded = "01.02.2023" },
            new BuildingTableModel() { BuildingId = 3, BuildingTitle = "Building Third", DateAdded = "01.03.2023" },
            new BuildingTableModel() { BuildingId = 4, BuildingTitle = "Building Four", DateAdded = "01.04.2023" },
            new BuildingTableModel() { BuildingId = 5, BuildingTitle = "Building Five", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
    public static List<BuildingTableModel> TestCollection(this List<BuildingTableModel> list)
    {
        var items = new List<BuildingTableModel>()
        {
            new BuildingTableModel() { BuildingId = 0, BuildingTitle = "Nothing selected", DateAdded = string.Empty },
            new BuildingTableModel() { BuildingId = 1, BuildingTitle = "Building First", DateAdded = "01.01.2023" },
            new BuildingTableModel() { BuildingId = 2, BuildingTitle = "Building Second", DateAdded = "01.02.2023" },
            new BuildingTableModel() { BuildingId = 3, BuildingTitle = "Building Third", DateAdded = "01.03.2023" },
            new BuildingTableModel() { BuildingId = 4, BuildingTitle = "Building Four", DateAdded = "01.04.2023" },
            new BuildingTableModel() { BuildingId = 5, BuildingTitle = "Building Five", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
}
