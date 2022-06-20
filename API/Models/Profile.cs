using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace API.Models
{
    public class Profile
    {
        [Key()]
        public string UsernameId { get; set; }
        [Required]
        public string Password { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}