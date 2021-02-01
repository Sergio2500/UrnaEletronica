using DDD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface ICandidatosRepository
    {
        void AdicionarCandidato(Candidatos candidatos);
        void EditarCandidato(Candidatos candidatos);
        void ExcluirCandidato(Candidatos candidatos);
        IEnumerable<Candidatos> ListarCandidatos();
    }
}
