using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface IIngressoRepository
    {       
        Task<List<IngressoModel>> BuscarIngressos(DateTime? dataInicio, DateTime? dataFim, string cpf, int? sessao);
        Task<IngressoModel> BuscarIngresso(int codigo);
        Task<IngressoModel> CriarIngresso(IngressoModel ingresso);
        Task DeletarIngresso(int codigo);
    }
}
