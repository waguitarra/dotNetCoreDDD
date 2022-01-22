using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usando para Criar as Migraçoes
            var connectionString = "Server=localhost;userid=developer;password=1234567;database=TrocaSementes";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
