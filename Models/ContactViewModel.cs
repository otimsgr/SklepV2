using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigJigSaw.Models
{
    public class ContactViewModel
    {
       
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Za długie")]
        public string Message { get; set; }
    }
}
