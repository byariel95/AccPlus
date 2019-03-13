


namespace AccPluss.Data.Entities
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Client
    {
        public int Id { get; set; }
        [MaxLength(15)]
        [Required]
        public string Nit { get; set; }
        [MaxLength(60)]
        [Required]
        
        public string Name { get; set; }
        [MaxLength(60)]
        [Required]
      
        public string LastName { get; set; }
        [MaxLength(50)]
        [Required]
        

        public string  Address { get; set; }
        [DefaultValue("true")]
        
        public bool Active { get; set; }
        [Required]
       
        public DateTime Birthdate { get; set; }

    }
}
