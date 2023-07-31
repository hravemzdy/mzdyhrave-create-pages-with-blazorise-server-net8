using FluentValidation;

namespace EmployeeManagementApp.Models;

public class JobTableModel
{
    public string JobId { get; set; }
    public string JobTitle { get; set; }
    public string DateAdded { get; set; }

    public JobTableModel()
    {
        JobId = string.Empty;
        JobTitle = string.Empty;
        DateAdded = string.Empty;
    }
}
