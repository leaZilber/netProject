using houseCommittee.core.models;
using Microsoft.EntityFrameworkCore;


namespace houseCommittee.data
{
    public class DataContext:DbContext
    {
        public DbSet<Message> MessageList { get; set; }
        public DbSet<Building> BuildingList { get; set; }
        public DbSet<Tenant> TenantList { get; set; }
        public DbSet<HouseCommittee> HouseCommitteeList { get; set; }
        //public DbSet<ServiceProvider> ServiceProviderList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DataBase=my_db");
        }
    }
}
