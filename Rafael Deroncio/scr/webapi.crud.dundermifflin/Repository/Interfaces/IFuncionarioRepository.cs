
using webapi.crud.dundermifflin.Arguments;
using webapi.crud.dundermifflin.Models;

namespace webapi.crud.dundermifflin.Repositories.Interfaces
{
    /// <summary>
    /// Interface para operações assíncronas relacionadas à entidade Funcionario.
    /// </summary>
    public interface IFuncionarioRepository
    {
        /// <summary>
        /// Recupera um Funcionario pelo seu ID.
        /// </summary>
        /// <param name="id">O ID do Funcionario.</param>
        /// <returns>O modelo do Funcionario recuperado.</returns>
        Task<FuncionarioModel> GetByIdAsync(int id);

        /// <summary>
        /// Recupera todos os Funcionarios.
        /// </summary>
        /// <returns>Uma lista de modelos de Funcionario.</returns>
        Task<IEnumerable<FuncionarioModel>> GetAllAsync();

        /// <summary>
        /// Cria um novo Funcionario.
        /// </summary>
        /// <param name="funcionario">O modelo do Funcionario a ser criado.</param>
        Task<bool> CreateAsync(FuncionarioArgument funcionario, bool commit=true);

        /// <summary>
        /// Atualiza um Funcionario existente.
        /// </summary>
        /// <param name="funcionario">O modelo do Funcionario atualizado.</param>
        Task<bool> UpdateAsync(FuncionarioArgument funcionario, bool commit=true);

        /// <summary>
        /// Exclui um Funcionario pelo seu ID.
        /// </summary>
        /// <param name="id">O ID do Funcionario a ser excluído.</param>
        Task<bool> DeleteAsync(int id, bool commit=true);
    }
}
