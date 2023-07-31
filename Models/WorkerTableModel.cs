namespace EmployeeManagementApp.Models;

public class WorkerTableModel
{
    public string WorkerId { get; set; }
    public string WorkerName { get; set; }
    public string WorkerAccessCode { get; set; }
    public string DateAdded { get; set; }

    public WorkerTableModel()
    {
        WorkerId = string.Empty;
        WorkerName = string.Empty;
        WorkerAccessCode = string.Empty;
        DateAdded = string.Empty;
    }
}
