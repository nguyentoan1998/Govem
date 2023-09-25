namespace InventoryManagement.Models.Northwind;

public class EmployeesType
{
    public double EmployeeID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public string TitleOfCourtesy { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }
    public AddressType Address { get; set; }
    public double ManagerID { get; set; }
    public string Notes { get; set; }
    public object[] TerritoryIDs { get; set; } = Array.Empty<object>();
    public string AvatarUrl { get; set; }
}
