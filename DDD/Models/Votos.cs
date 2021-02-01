using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Models
{
    public class Votos
    {
        public int IdVotos { get; set; }
        public Candidatos CandidatoId { get; set; }
        public DateTime DataVoto { get; set; }
        public string CodigoVoto { get; set; }
    }
}
