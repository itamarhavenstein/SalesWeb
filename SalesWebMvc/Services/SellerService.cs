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
  }
}