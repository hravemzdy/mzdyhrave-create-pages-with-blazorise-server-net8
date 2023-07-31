using FluentValidation;

namespace EmployeeManagementApp.Models;

public class JobAddModel
{
    public string Title { get; set; }

    public JobAddModel()
    {
        Title = string.Empty;
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