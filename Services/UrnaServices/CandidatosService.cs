using DataLayer.Interfaces;
using DDD.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UrnaServices
{
    public class CandidatosService : ICandidatosService
    {
        private readonly ICandidatosRepository repository;

        public CandidatosService(ICandidatosRepository candidatosRepository)
        {
            repository = candidatosRepository;
        }

        public void AdicionarCandidato(Candidatos candidatos)
        {
            repository.AdicionarCandidato(candidatos);
        }

        public void EditarCandidato(Candidatos candidatos)
        {
            repository.EditarCandidato(candidatos);
        }

        public void ExcluirCandidato(Candidatos candidatos)
        {
            repository.ExcluirCandidato(candidatos);
        }

        public IEnumerable<Candidatos> ListarCandidatos()
        {
            var candidatos = repository.ListarCandidatos();
            var listaCandidatos = new List<Candidatos>();
            foreach (var candidato in listaCandidatos)
            {
                listaCandidatos.Add(candidato);
            }
            return listaCandidatos;
        }
    }
}
