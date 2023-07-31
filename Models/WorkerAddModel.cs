using FluentValidation;
using System;

namespace EmployeeManagementApp.Models;

public class WorkerAddModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public WorkerAddModel()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
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