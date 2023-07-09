using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {

        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.GetById(x => x.ID == id);
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }
        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }



    }
}
