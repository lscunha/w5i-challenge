using System;
using System.ComponentModel.DataAnnotations;

namespace w5i.Models
{
    public class RegistroAcesso
    {
        public int Id { get; set; }

        [Required]
        public int PessoaId { get; set; }

        [Required]
        public DateTime DataHoraEntrada { get; set; }

        public DateTime? DataHoraSaida { get; set; }

        public TimeSpan? Duracao
        {
            get
            {
                if (DataHoraSaida.HasValue)
                {
                    return DataHoraSaida.Value - DataHoraEntrada;
                }
                return null;
            }
        }

        public Pessoa Pessoa { get; set; }
    }
}