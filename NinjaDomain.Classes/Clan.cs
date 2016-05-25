namespace NinjaDomain.Classes
{
    using System.Collections.Generic;

    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }
}
