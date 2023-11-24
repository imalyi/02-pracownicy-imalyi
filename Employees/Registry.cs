
using System.Collections.Generic;
using System.Linq;

namespace _02_pracownicy_imalyi
{
    public class Registry
    {
        private List<Employee> _registry = new List<Employee>();

        public Registry()
        {

        }

        public void Add(Employee employee)
        {
            _registry.Add(employee);
        }

        public Employee Remove(uint id)
        {
            var itemToRemove = _registry.FirstOrDefault(item => item.Id == id);
            _registry.Remove(itemToRemove);
            return itemToRemove;
        }


        public void BulkAdd(List<Employee> employees)
        {
            _registry.AddRange(employees);
        }

        public List<Employee> GetEmployeesByCity(string city)
        {
            return _registry.Where(employee => employee.Address.City == city).ToList();
        }

        public List<Employee> GetSortedEmployeesList()
        {
            return _registry.OrderByDescending(e => e.Experience)
                .ThenBy(e => e.Age)
                .ThenBy(e => e.Surname).ToList();
        }
    }
}