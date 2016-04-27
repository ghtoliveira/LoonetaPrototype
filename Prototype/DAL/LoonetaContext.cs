using Prototype.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Prototype.DAL {
    public class LoonetaContext : DbContext {
        public LoonetaContext() : base("LoonetaContext") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
        public DbSet<Reclamacao> Reclamacoes { get; set; }
        public DbSet<TagReclamacao> TagsReclamacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

    }
}