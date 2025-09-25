using System.CodeDom.Compiler;
using DemoMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using DemoMvc.Helpers;

namespace DemoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }


        public IActionResult Create()
        {
            var lastEmployee = _context.Employees
                   .OrderByDescending(e => e.PersonId)
                   .FirstOrDefault();

            string newId = Helpers.CodeGenerator.GenerateNextCode(lastEmployee.PersonId, "EMP", 3);

            var employee = new Employee
            {
                PersonId = newId,
                FullName = string.Empty,
                Address = string.Empty,
                Age = 0
            };


    return View(employee);
}


        private string GenerateNextId(object employeeId, string v1, int v2)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,FullName,Address,Age")] Employee employee)
        {
            if (ModelState.IsValid)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
        }
    }
}

