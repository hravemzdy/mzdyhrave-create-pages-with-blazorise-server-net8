using EmployeeManagementApp.Models.Interfaces;
using FluentValidation;

namespace EmployeeManagementApp.Models;

public class JobTableModel : IAssetSelectItem<int>
{
    public int Id => JobId;
    public string TableId => JobId.ToString();
    public string Name => JobTitle;
    public int JobId { get; set; }
    public string JobTitle { get; set; }
    public string DateAdded { get; set; }

    public JobTableModel()
    {
        JobId = 0;
        JobTitle = string.Empty;
        DateAdded = string.Empty;
    }
}
