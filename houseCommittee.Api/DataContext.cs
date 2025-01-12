using houseCommittee.core.models;
using Microsoft.EntityFrameworkCore;

public class DataContext: DbContext
{
        public DbSet<Message> MessageDbSet { get; set; }
        public DbSet<Building> BuildingDbSet { get; set; }
        public DbSet<Tenant> TenantDbSet { get; set; }
        public DbSet<HouseCommittee> HouseCommitteeDbSet { get; set; }
}
