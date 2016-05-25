namespace NinjaDomain.Classes
{
    using Enums;
    using System.ComponentModel.DataAnnotations;

    public class NinjaEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja{ get; set; }
    }
}
