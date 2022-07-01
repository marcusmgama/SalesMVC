using SalesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesMVCContext _context;

        public DepartmentService(SalesMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Departments>> FindAllAsync()
        {
            return await _context.Departments.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

//FindAll síncrono
//
// public List<Departments> FindAll()
//        {
//            return _context.Departments.OrderBy(x => x.Name).ToList();
//        }
//    }
//}
