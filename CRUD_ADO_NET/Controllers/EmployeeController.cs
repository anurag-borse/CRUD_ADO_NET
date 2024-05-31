using CRUD_ADO_NET.Data;
using CRUD_ADO_NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ADO_NET.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            EmployeeRepository employeeRepository = new EmployeeRepository();

            employees = employeeRepository.GetEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();

                    if (employeeRepository.AddEmployee(employee))
                    {
                        return RedirectToAction("Index");
                    }

                }
                return View();
            }
            catch
            {
                return View();
            }


        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employees = new Employee();
            EmployeeRepository employeeRepository = new EmployeeRepository();

            employees = employeeRepository.GetEmployeesByID(id);
            return View(employees);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();

                    if (employeeRepository.UpdateEmployee(id, employee))
                    {
                        return RedirectToAction("Index");
                    }

                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employees = new Employee();
            EmployeeRepository employeeRepository = new EmployeeRepository();

            employees = employeeRepository.GetEmployeesByID(id);
            return View(employees);
        }



        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();

                if (employeeRepository.DeleteEmployee(employee.ID))
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }



        }
    }
}
