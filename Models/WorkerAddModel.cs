using EmployeeManagementApp.Models.Interfaces;
using FluentValidation;
using System;

namespace EmployeeManagementApp.Models;

public class WorkerAddModel : IClearableModel, IAddTableModel<WorkerTableModel, WorkerAddModel>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public WorkerAddModel()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public void Clear()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public WorkerTableModel CreateTableModel()
    {
        return new WorkerTableModel()
        {
            WorkerId = 100,
            WorkerFirstName = FirstName,
            WorkerLastName = LastName,
            WorkerAccessCode = "X",
            DateAdded = "Now"
        };
    }
}

public class WorkerAddValidator : AbstractValidator<WorkerAddModel>
{
    public WorkerAddValidator()
    {
        RuleFor(vm => vm.FirstName)
            .NotEmpty()
            .MaximumLength(30);

        RuleFor(vm => vm.LastName)
            .NotEmpty()
            .MaximumLength(30);
    }
}