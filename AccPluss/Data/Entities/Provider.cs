



namespace AccPluss.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Provider : IEntity
    {
        public int Id { get; set; }
        [MaxLength(15)]
        [Required]
        public string Nit { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
