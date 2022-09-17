using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
  public class SellerService
  {
    private readonly SalesWebContext _context;

    public SellerService(SalesWebContext context)
    {
      _context = context;
    }

    public List<Seller> FindAll()
    {
      return _context.Seller.ToList();
    }

    public void Insert(Seller obj){
      //provisorio
      obj.Department = _context.Department.First();
      _context.Add(obj);
      _context.SaveChanges();
    }
  }
}