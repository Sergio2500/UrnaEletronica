using DDD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICandidatosService
    {
        void AdicionarCandidato(Candidatos candidatos);
        void EditarCandidato(Candidatos candidatos);
        void ExcluirCandidato(Candidatos candidatos);
        IEnumerable<Candidatos> ListarCandidatos();
    }
}
