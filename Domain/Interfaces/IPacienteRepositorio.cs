using Domain.Models;

namespace Domain.Interfaces;

public interface IPacienteRepositorio
{
    Task<ValueResult<List<PacienteModel>>> BuscarTodosPacientes();
    Task<ValueResult<PacienteModel>> BuscarTodosPacientes(int id);
    Task<ValueResult<PacienteModel>> Adicionar(PacienteModel paciente);
    Task<ValueResult<PacienteModel>> Atualizar(PacienteModel paciente, int id);
    Task<ValueResult> Apagar(int id);
}
