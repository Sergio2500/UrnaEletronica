using DataLayer.Interfaces;
using DataLayer.Mapping;
using DDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repositories
{
    public class CandidatosRepository : ICandidatosRepository
    {
        private readonly ApplicationContext context;

        public CandidatosRepository(ApplicationContext applicationContext)
        {
            context = applicationContext;
        }

        public void AdicionarCandidato(Candidatos candidatos)
        {
            context.CandidatosContext.Add(candidatos);
            context.SaveChanges();
        }

        public void EditarCandidato(Candidatos candidatos)
        {
            context.CandidatosContext.Update(candidatos);
            context.SaveChanges();
        }

        public void ExcluirCandidato(Candidatos candidatos)
        {
            context.CandidatosContext.Remove(candidatos);
            context.SaveChanges();
        }

        public IEnumerable<Candidatos> ListarCandidatos()
        {
            var candidatos = context.CandidatosContext.ToList();
            //var candidatos = new Candidatos();
            var listaCandidatos = new List<Candidatos>();

            foreach (var candidato in candidatos)
            {
                listaCandidatos.Add(candidato);
            }

            return listaCandidatos;

        }
    }
}
