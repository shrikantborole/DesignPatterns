using Observer;

Console.Title = "Observer";

AundCompanyBranch aundCompanyBranch = new AundCompanyBranch();
WakadCompanyBranch wakadCompanyBranch= new WakadCompanyBranch();

EmployeeUpdate employeeUpdate = new EmployeeUpdate();
employeeUpdate.AddObserver(aundCompanyBranch);
employeeUpdate.AddObserver(wakadCompanyBranch);

employeeUpdate.Resign(new Employee() { Name = "ABC", DOB = "15May91" });
employeeUpdate.Joined(new Employee() { Name = "XYZ", DOB = "15May98" });
Console.WriteLine();

