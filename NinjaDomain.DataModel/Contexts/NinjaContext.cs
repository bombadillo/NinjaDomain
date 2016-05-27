namespace NinjaDomain.Data.Contexts
{
    using System.Data.Entity;
    using Classes;

    public class NinjaContext : DbContext, INinjaContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
