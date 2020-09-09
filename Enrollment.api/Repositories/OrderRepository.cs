using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enrollment.api.Helpers;
using Enrollment.api.Model;
using Enrollment.api.Model.Data;
using Enrollment.api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.api.Repositoriesdotn
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<DepOrder>> GetDepOrders()
        {
            var orders = await _context.DepOrders.ToListAsync();

            return orders;
        }
    }
}