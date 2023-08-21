using TODOSystem.Models;

namespace TODOSystem.Repository.Interfaces
{
    //galera costuma chamar o Repository onde define os 'contratos' do model
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> findAllUsuarios();

        Task<UsuarioModel> findById(int id);

        Task<UsuarioModel> Add(UsuarioModel usario);

        Task<UsuarioModel> Update(UsuarioModel usuario, int id);

        Task<bool> Delete (int id);




    }
}
