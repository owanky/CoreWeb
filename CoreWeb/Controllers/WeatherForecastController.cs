using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace CoreWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    private readonly BaseContext _context;
    
    public EmployeeController(BaseContext context)
    {
  
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Employee> GetEmployee()
    {
        //TODO 16. Napisz zapytanie wyświetlające nazwę, w tym imię i nazwisko
        //TODO oraz wynagrodzenie dla wszystkich pracowników,
        //TODO których wynagrodzenie jest spoza przedziału od 10 000 do 15 000. [employees]

        /*
         CRTL+SHIFT+/
         var result = _context.Employees
            .Where(e => (e.Salary < 10000 || e.Salary > 15000))
            .Select(e => e)
            .ToList();
        return result;
        */
       
        
        //TODO 17. Napisz zapytanie wyświetlające nazwiska pracowników,
        //TODO których nazwiska składają się z dokładnie 5 znaków. [employees]
        
        /*
        var result = _context.Employees
            .Where(e => e.LastName.Length < 6)
            .ToList();
        return result;
        */
        
        //TODO 21. Napisz zapytanie, aby uzyskać job_id i ID(s) tych pracowników,
        //TODO którzy pracują na danym stanowisku.

        /* NIEDOKOŃCZONE
        var result = _context.Employees
            .GroupBy(e => e.JobId)
            .Select(e => 
                
                )
            .ToList();
        return result;
        */
        
        // TODO 22. Napisz zapytanie wyświetlające imię, nazwisko oraz pensję osób,
        // TODO które pracują w dziale 60 || 90 || 110 || 120,
        // TODO a ich pensja jest spoza przedziału 7000 - 8000, wynik posortuj maqlejąco. [employees]
        
        
        /*
         var result = _context.Employees
           .Where(e => (e.DepartmentId==60 || e.DepartmentId==90))
           .Where(e => (e.Salary <7000 || e.Salary >8000))
           .OrderByDescending(e=> e.FirstName)
           .Select(e => e)
           .ToList();
       return result;
       */

        //TODO 25. Napisz zapytanie wyświetlające imie kazdego pracownika,
        //TODO którzy mają zarówno "b" jak i "c" w swoim imieniu. [employees]
        
        
         /*var result = _context.Employees
           .Where(e => (e.FirstName.ToLower().Contains("b") && e.FirstName.ToLower().Contains("c")))
           .Select(e => e)
           .ToList();
       return result;*/

       //TODO 28. Napisz zapytanie wyświetlające nazwisko, stanowisko oraz wynagrodzenie dla wszystkich pracowników,
       //TODO których stanowisko to IT_PROG lub SH_CLERK, a wynagrodzenie nie jest równe 4500, 10000 lub 15000,
       //TODO wynik posortuj rosnąco. [employees]
       
       var result = _context.Employees
         .Where(e => (e.JobId == "IT_PROG" || e.JobId == "SH_CLERK"))
         .Where(e => (e.Salary != 4500 && e.Salary != 10000 && e.Salary != 15000))
         .OrderBy(e=> e.JobId)
         .Select(e => e)
         .ToList();
        return result;

    }
}