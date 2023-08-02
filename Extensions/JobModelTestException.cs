using EmployeeManagementApp.Models;

namespace EmployeeManagementApp.Extensions;

public static class JobModelTestException
{
    public static List<JobTableModel> TestTableCollection(this List<JobTableModel> list)
    {
        var items = new List<JobTableModel>()      
        {
            new JobTableModel() { JobId = 1, JobTitle = "Job First", DateAdded = "01.01.2023" },
            new JobTableModel() { JobId = 2, JobTitle = "Job Second", DateAdded = "01.02.2023" },
            new JobTableModel() { JobId = 3, JobTitle = "Job Third", DateAdded = "01.03.2023" },
            new JobTableModel() { JobId = 4, JobTitle = "Job Four", DateAdded = "01.04.2023" },
            new JobTableModel() { JobId = 5, JobTitle = "Job Five", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
    public static List<JobTableModel> TestCollection(this List<JobTableModel> list)
    {
        var items = new List<JobTableModel>()
        {
            new JobTableModel() { JobId = 0, JobTitle = "Nothing selected", DateAdded = string.Empty },
            new JobTableModel() { JobId = 1, JobTitle = "Job First", DateAdded = "01.01.2023" },
            new JobTableModel() { JobId = 2, JobTitle = "Job Second", DateAdded = "01.02.2023" },
            new JobTableModel() { JobId = 3, JobTitle = "Job Third", DateAdded = "01.03.2023" },
            new JobTableModel() { JobId = 4, JobTitle = "Job Four", DateAdded = "01.04.2023" },
            new JobTableModel() { JobId = 5, JobTitle = "Job Five", DateAdded = "01.05.2023" },
        };

        return list.Concat(items).ToList();
    }
}
