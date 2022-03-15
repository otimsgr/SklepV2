using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BigJigSaw.Models

{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Producent")]
        public string Producer { get; set; }

        [Required]
        [DisplayName("Model")]        
        public string Model { get; set; }

        [Required]
        [DisplayName("Cena")]
        [Range(1, int.MaxValue, ErrorMessage ="Cena musi byc wieksza od 0")]
        public int Price { get; set; }
    }
}
