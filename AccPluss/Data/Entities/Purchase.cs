

namespace AccPluss.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class Purchase : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string NoDocument { get; set; }
        [Required]
        public DateTime Date { get; set; }

      
        [MaxLength(30)]
        public string TypeDocument { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Import { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Total { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal NetPrice { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Iva { get; set; }


        [Required]
        public virtual Provider Provider { get; set; }

        [Required]
        public virtual Client Client { get; set; }
    }
}
