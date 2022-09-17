using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
  public class DepartmentService
  {
    private readonly SalesWebContext _context;

    public DepartmentService(SalesWebContext context)
    {
      _context = context;
    }

    public List<Department> FindAll(){
      return _context.Department.OrderBy(x => x.Name).ToList();
    }
  }
}