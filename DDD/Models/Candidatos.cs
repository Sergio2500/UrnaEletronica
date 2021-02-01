using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Models
{
    public class Candidatos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Vice { get; set; }
        public DateTime DataRegistro { get; set; }
        public int Legenda { get; set; }
        public int TipoCandidato { get; set; }

        public List<Votos> VotosId { get; set; }
    }
}
