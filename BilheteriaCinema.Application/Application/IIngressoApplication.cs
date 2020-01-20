using System;
using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface IIngressoApplication
    {
        Task<IngressoDTO> BuscarIngresso(int codigo);
        Task<List<IngressoDTO>> BuscarIngressos(DateTime? dataInicio, DateTime? dataFim, string cpf, int? sessao);
        Task<IngressoDTO> ComprarIngresso(IngressoDTO ingresso);
        Task CancelarCompra(int codigo);
    }
}
