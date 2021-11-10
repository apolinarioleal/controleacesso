using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace controle.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column("Nome")]
        [MaxLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}
