namespace EmployeeManagementApp.Models.Interfaces;

public interface IAssetSelectItem<CItem>
{
    CItem Id { get; }
    string TableId { get; }
    string Name { get; }
}
