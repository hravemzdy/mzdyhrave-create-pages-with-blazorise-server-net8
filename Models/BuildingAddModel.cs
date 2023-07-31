using FluentValidation;

namespace EmployeeManagementApp.Models;

public class BuildingAddModel
{
    public string Title { get; set; }

    public BuildingAddModel()
    {
        Title = string.Empty;
    }
}
public class BuildingAddValidator : AbstractValidator<BuildingAddModel>
{
    public BuildingAddValidator()
    {
        RuleFor(vm => vm.Title)
            .NotEmpty()
            .MaximumLength(30);
    }
}