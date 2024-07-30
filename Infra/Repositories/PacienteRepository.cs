using Domain;
using Domain.Interfaces;
using Domain.Models;

namespace Infra.Repositories
{
    internal class PacienteRepository : IPacienteRepositorio
    {
        public Task<ValueResult<PacienteModel>> Adicionar(PacienteModel paciente)
        {
            throw new NotImplementedException();
        }

        public Task<ValueResult> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ValueResult<PacienteModel>> Atualizar(PacienteModel paciente, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ValueResult<List<PacienteModel>>> BuscarTodosPacientes()
        {
            throw new NotImplementedException();
        }

        public Task<ValueResult<PacienteModel>> BuscarTodosPacientes(int id)
        {
            throw new NotImplementedException();
        }
    }
}
