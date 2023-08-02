using EmployeeManagementApp.Components.ManageGrid;
using FluentValidation;

namespace EmployeeManagementApp.Models;

public class BuildingAddModel : IAddTableModel<BuildingTableModel, BuildingAddModel>
{
    public string Title { get; set; }

    public BuildingAddModel()
    {
        Title = string.Empty;
    }
    public void Clear()
    {
        Title = string.Empty;
    }

    public BuildingTableModel CreateTableModel()
    {
        return new BuildingTableModel() 
        {
            BuildingId = 100,
            BuildingTitle = Title,
            DateAdded = "Now"
        };
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