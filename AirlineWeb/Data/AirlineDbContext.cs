using AirlineWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineWeb.Data
{
    public class AirlineDbContext : DbContext
    {
        public AirlineDbContext(DbContextOptions<AirlineDbContext> opt) : base(opt)
        {

        }

        public DbSet<WebhookSubscription> webhookSubscriptions { get; set; }
        public DbSet<FlightDetail> flightDetails { get; set; }
    }
}