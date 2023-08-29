using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using w5i.Data;

namespace w5i.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public ICollection<RegistroAcesso> RegistrosAcesso { get; set; }
    }
}