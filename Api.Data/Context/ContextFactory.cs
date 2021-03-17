using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {

        public MyContext CreateDbContext(string[] args)
        {

            //Usado para Criar as Migrações
            var connectionString = "Server=u3r5w4ayhxzdrw87.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;Port=3306;DataBase=eaprhzvd8iuybe87;Uid=sg27jh0rebezh07s;Pwd=fyn4seq4red3o5zl";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder
            .UseMySql(connectionString);
            //optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
