using System.Data.Entity;

namespace ControleEstoque1
{
    public class Context: DbContext
    {
        public Context() : base("ControleEstoque")
        {
        }
        public DbSet<DtoUsuario> usuario { get; set; }
        public DbSet<DtoProduto> produto { get; set; }
    }
}
