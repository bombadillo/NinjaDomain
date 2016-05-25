namespace NinjaDomain.DataModel
{
    using System.Data.Entity;
    using Classes;

    public class NinjaContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
