using EmployeeManagementApp.Components.ManageGrid;
using FluentValidation;

namespace EmployeeManagementApp.Models;

public class JobAddModel : IAddTableModel<JobTableModel, JobAddModel>
{
    public string Title { get; set; }

    public JobAddModel()
    {
        Title = string.Empty;
    }

    public void Clear()
    {
        Title = string.Empty;
    }
    public JobTableModel CreateTableModel()
    {
        return new JobTableModel()
        {
            JobId = 100,
            JobTitle = Title,
            DateAdded = "Now"
        };
    }
}
public class JobAddValidator : AbstractValidator<JobAddModel>
{
    public JobAddValidator()
    {
        RuleFor(vm => vm.Title)
            .NotEmpty()
            .MaximumLength(30);
    }
}