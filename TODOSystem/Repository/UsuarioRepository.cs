using TODOSystem.Data;
using TODOSystem.Models;
using TODOSystem.Repository.Interfaces;

namespace TODOSystem.Repository
{

    //em IUsuarioRepository definimos os 'contratos'
    //ja em UsuarioRepository assinamos estes 'contratos'
    public class UsuarioRepository : IUsuarioRepository
    {
        //criando um obj do TodoSystemDBContext chamado _dbContxt do tipo protegido p/ poder receber o contexto do Db;
        private readonly TodoSystemDBContext _dbContext;

        public UsuarioRepository(TodoSystemDBContext todoSystemDBContext) {
            //passando o contexto 'original' pro obj protegido;
            _dbContext = todoSystemDBContext;
        }
    
        //metodos de busca
        public Task<UsuarioModel> findById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Update(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        //métodos de persistencia
        public Task<UsuarioModel> Add(UsuarioModel usario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> findAllUsuarios()
        {
            throw new NotImplementedException();
        }

        
    }
}
