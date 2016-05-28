namespace NinjaDomain.Data.Contexts
{
    using System.Data.Entity;
    using Classes;

    public interface INinjaContext
    {
        DbSet<Ninja> Ninjas { get; set; }
        DbSet<Clan> Clans { get; set; }
        DbSet<NinjaEquipment> Equipment { get; set; }

        int SaveChanges();
    }
}
