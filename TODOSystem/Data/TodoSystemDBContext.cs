using Microsoft.EntityFrameworkCore;
using TODOSystem.Models;

namespace TODOSystem.Data
{
    //criacao do DB usando DbContext do Entity
    public class TodoSystemDBContext : DbContext
    {
        //passando as config do Db via construtor da classe
        public TodoSystemDBContext(DbContextOptions<TodoSystemDBContext> options) :
            base(options)
        { 
        }

        //DbSet para ORM, basicamente ta abstraindo e construindo as tabelas
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TasksModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
