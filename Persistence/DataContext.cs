using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }

        public DbSet<HotelServices> HotelServices { get; set; }

        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBookingStatus> RoomBookingStatuses { get; set; }
       public DbSet<TransactionTableforUserAction> TransactionTableforUserActions { get; set; }
    }
}