using EmployeeManagementApp.Models.Interfaces;

namespace EmployeeManagementApp.Models;

public class WorkerTableModel : IAssetSelectItem<int>
{
    public int Id => WorkerId;
    public string TableId => WorkerId.ToString();
    public string Name => WorkerName;

    public int WorkerId { get; set; }
    public string WorkerName { get => string.Join(" ", WorkerLastName, WorkerFirstName); }
    public string WorkerFirstName { get; set; }
    public string WorkerLastName { get; set; }
    public string WorkerAccessCode { get; set; }
    public string DateAdded { get; set; }


    public WorkerTableModel()
    {
        WorkerId = 0;
        WorkerFirstName = string.Empty;
        WorkerLastName = string.Empty;
        WorkerAccessCode = string.Empty;
        DateAdded = string.Empty;
    }
}
