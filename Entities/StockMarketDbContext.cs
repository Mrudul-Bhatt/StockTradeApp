using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class StockMarketDbContext : DbContext
    {
        public StockMarketDbContext(DbContextOptions<StockMarketDbContext> options) : base(options)
        {
        }

        public DbSet<BuyOrder>? BuyOrders { get; set; }
        public DbSet<SellOrder>? SellOrders { get; set; }
    }
}