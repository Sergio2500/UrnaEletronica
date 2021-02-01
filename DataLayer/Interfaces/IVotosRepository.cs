using DDD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IVotosRepository
    {
        void AdicionarVotos(Votos votos);
        void EditarVotos(Votos votos);
        void ExcluirVotos(Votos votos);
        IEnumerable<Votos> Votos();
    }
}
