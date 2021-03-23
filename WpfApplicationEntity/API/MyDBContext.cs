using System.Data.Entity;
using WpfApplicationEntity.API;

namespace WFAEntWpfApplicationEntityity.API
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnectString")
        {
        }
       /* public DbSet<Calls> Callss { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Detali> Detalies { get; set; }
        public DbSet<Plan_ystanovki_lifts> Plan_Ystanovki_Liftss { get; set; }
        public DbSet<Sotrydnik> Sotrydniks { get; set; }
        public DbSet<Detali_calls> Detali_callss { get; set; }
        public DbSet<Lifts> Liftss { get; set; }*/
    }
}
