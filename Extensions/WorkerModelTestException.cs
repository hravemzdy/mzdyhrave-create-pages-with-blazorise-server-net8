using EmployeeManagementApp.Models;
using System.Linq;

namespace EmployeeManagementApp.Extensions;

public static class WorkerModelTestException
{
    public static List<WorkerTableModel> TestTableCollection(this List<WorkerTableModel> list)
    {
        var items = new List<WorkerTableModel>()      
        {
            new WorkerTableModel() { WorkerId = 11, WorkerLastName = "Worker", WorkerFirstName = "First", WorkerAccessCode = "A", DateAdded = "01.01.2023" },
            new WorkerTableModel() { WorkerId = 12, WorkerLastName = "Worker", WorkerFirstName = "Second", WorkerAccessCode = "B", DateAdded = "01.02.2023" },
            new WorkerTableModel() { WorkerId = 13, WorkerLastName = "Worker", WorkerFirstName = "Third", WorkerAccessCode = "C", DateAdded = "01.03.2023" },
            new WorkerTableModel() { WorkerId = 14, WorkerLastName = "Worker", WorkerFirstName = "Four", WorkerAccessCode = "D", DateAdded = "01.04.2023" },
            new WorkerTableModel() { WorkerId = 15, WorkerLastName = "Worker", WorkerFirstName = "Five", WorkerAccessCode = "E", DateAdded = "01.05.2023" },
            new WorkerTableModel() { WorkerId = 21, WorkerLastName = "Worker", WorkerFirstName = "First", WorkerAccessCode = "A", DateAdded = "01.01.2023" },
            new WorkerTableModel() { WorkerId = 22, WorkerLastName = "Worker", WorkerFirstName = "Second", WorkerAccessCode = "B", DateAdded = "01.02.2023" },
            new WorkerTableModel() { WorkerId = 23, WorkerLastName = "Worker", WorkerFirstName = "Third", WorkerAccessCode = "C", DateAdded = "01.03.2023" },
            new WorkerTableModel() { WorkerId = 24, WorkerLastName = "Worker", WorkerFirstName = "Four", WorkerAccessCode = "D", DateAdded = "01.04.2023" },
            new WorkerTableModel() { WorkerId = 25, WorkerLastName = "Worker", WorkerFirstName = "Five", WorkerAccessCode = "E", DateAdded = "01.05.2023" },
            new WorkerTableModel() { WorkerId = 31, WorkerLastName = "Worker", WorkerFirstName = "First", WorkerAccessCode = "A", DateAdded = "01.01.2023" },
            new WorkerTableModel() { WorkerId = 32, WorkerLastName = "Worker", WorkerFirstName = "Second", WorkerAccessCode = "B", DateAdded = "01.02.2023" },
            new WorkerTableModel() { WorkerId = 33, WorkerLastName = "Worker", WorkerFirstName = "Third", WorkerAccessCode = "C", DateAdded = "01.03.2023" },
            new WorkerTableModel() { WorkerId = 34, WorkerLastName = "Worker", WorkerFirstName = "Four", WorkerAccessCode = "D", DateAdded = "01.04.2023" },
            new WorkerTableModel() { WorkerId = 35, WorkerLastName = "Worker", WorkerFirstName = "Five", WorkerAccessCode = "E", DateAdded = "01.05.2023" },
            new WorkerTableModel() { WorkerId = 41, WorkerLastName = "Worker", WorkerFirstName = "First", WorkerAccessCode = "A", DateAdded = "01.01.2023" },
            new WorkerTableModel() { WorkerId = 42, WorkerLastName = "Worker", WorkerFirstName = "Second", WorkerAccessCode = "B", DateAdded = "01.02.2023" },
            new WorkerTableModel() { WorkerId = 43, WorkerLastName = "Worker", WorkerFirstName = "Third", WorkerAccessCode = "C", DateAdded = "01.03.2023" },
            new WorkerTableModel() { WorkerId = 44, WorkerLastName = "Worker", WorkerFirstName = "Four", WorkerAccessCode = "D", DateAdded = "01.04.2023" },
            new WorkerTableModel() { WorkerId = 45, WorkerLastName = "Worker", WorkerFirstName = "Five", WorkerAccessCode = "E", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
    public static List<WorkerTableModel> TestCollection(this List<WorkerTableModel> list)
    {
        var items = new List<WorkerTableModel>()      
        {
            new WorkerTableModel() { WorkerId =  0, WorkerLastName = "Nothing", WorkerFirstName = "selected", WorkerAccessCode = string.Empty, DateAdded = string.Empty },
            new WorkerTableModel() { WorkerId = 11, WorkerLastName = "Worker", WorkerFirstName = "First", WorkerAccessCode = "A", DateAdded = "01.01.2023" },
            new WorkerTableModel() { WorkerId = 12, WorkerLastName = "Worker", WorkerFirstName = "Second", WorkerAccessCode = "B", DateAdded = "01.02.2023" },
            new WorkerTableModel() { WorkerId = 13, WorkerLastName = "Worker", WorkerFirstName = "Third", WorkerAccessCode = "C", DateAdded = "01.03.2023" },
            new WorkerTableModel() { WorkerId = 14, WorkerLastName = "Worker", WorkerFirstName = "Four", WorkerAccessCode = "D", DateAdded = "01.04.2023" },
            new WorkerTableModel() { WorkerId = 15, WorkerLastName = "Worker", WorkerFirstName = "Five", WorkerAccessCode = "E", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
}
