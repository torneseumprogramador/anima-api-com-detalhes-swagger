using webapi.crud.dundermifflin.Requests;
using webapi.crud.dundermifflin.Responses;

namespace webapi.crud.dundermifflin.Services.Interfaces
{
    /// <summary>
    /// Interface para o serviço de Funcionário.
    /// </summary>
    public interface IFuncionarioService
    {
        /// <summary>
        /// Obtém as informações de um funcionário específico.
        /// </summary>
        /// <param name="id">O ID do funcionário.</param>
        /// <returns>O objeto FuncionarioResponse contendo as informações do funcionário.</returns>
        Task<FuncionarioResponse> GetFuncionario(int id);

        /// <summary>
        /// Obtém uma lista de todos os funcionários.
        /// </summary>
        /// <returns>Uma lista de objetos FuncionarioResponse contendo as informações dos funcionários.</returns>
        Task<IEnumerable<FuncionarioResponse>> GetFuncionarios();

        /// <summary>
        /// Cria um novo funcionário com base nas informações fornecidas.
        /// </summary>
        /// <param name="funcionarioRequest">O objeto FuncionarioRequest contendo as informações do novo funcionário.</param>
        /// <returns>O objeto FuncionarioResponse contendo as informações do funcionário recém-criado.</returns>
        Task<FuncionarioResponse> CreateFuncionario(FuncionarioRequest funcionarioRequest);

        /// <summary>
        /// Atualiza as informações de um funcionário existente.
        /// </summary>
        /// <param name="id">O ID do funcionário a ser atualizado.</param>
        /// <param name="funcionarioRequest">O objeto FuncionarioRequest contendo as novas informações do funcionário.</param>
        /// <returns>O objeto FuncionarioResponse contendo as informações atualizadas do funcionário.</returns>
        Task<bool> UpdateFuncionario(int id, FuncionarioRequest funcionarioRequest);

        /// <summary>
        /// Exclui um funcionário existente com base no ID fornecido.
        /// </summary>
        /// <param name="id">O ID do funcionário a ser excluído.</param>
        Task<bool> DeleteFuncionario(int id);
    }
}
