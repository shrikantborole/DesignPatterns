namespace Observer
{
	public class Employee
	{
		public string Name { get; set; }
		public string DOB { get; set; }
	}

    /// <summary>
    /// Observer
    /// </summary>
    public interface ISubCompanyBranchChangeListener
    {
        void ReceiveEmployeUpdateNotification(Employee employee);
    }

    /// <summary>
    /// Observer Implementation
    /// </summary>
    public class AundCompanyBranch : ISubCompanyBranchChangeListener
    {
        public void ReceiveEmployeUpdateNotification(Employee employee)
        {
            Console.WriteLine($"Company Branch {nameof(AundCompanyBranch)} notified, for Employee Name:- {employee.Name}");
        }
    }
    /// <summary>
    /// Observer Implementation
    /// </summary>
    public class WakadCompanyBranch : ISubCompanyBranchChangeListener
    {
        public void ReceiveEmployeUpdateNotification(Employee employee)
        {
            Console.WriteLine($"Company Branch {nameof(WakadCompanyBranch)} notified, for Employee Name:- {employee.Name}");
        }
    }

    /// <summary>
    /// Class to add/remove observer and notify them
    /// </summary>
    public abstract class EmployeeUpdateNotifier
    {
        private List<ISubCompanyBranchChangeListener> _observers = new();

        public void AddObserver(ISubCompanyBranchChangeListener subCompanyBranchChangeListener)
        {
            _observers.Add(subCompanyBranchChangeListener);
        }

        public void RemoveObserver(ISubCompanyBranchChangeListener subCompanyBranchChangeListener)
        {
            _observers.Remove(subCompanyBranchChangeListener);
        }

        public void Notify(Employee employee)
        {
            foreach (var observer in _observers)
            {
                observer.ReceiveEmployeUpdateNotification(employee);
            }
        }
    }
    public class EmployeeUpdate : EmployeeUpdateNotifier
    {
        public void Resign(Employee employee)
        {
            Console.WriteLine($"Employee resigned, {employee.Name}");
            Notify(employee);
        }

        public void Joined(Employee employee)
        {
            Console.WriteLine($"Employee joined, {employee.Name}");
            Notify(employee);
        }
    }
}
