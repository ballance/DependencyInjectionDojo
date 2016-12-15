using Autofac;
using dojo.lib;
using dojo.lib.FootClan;
using dojo.lib.Pizzas;
using dojo.lib.Traits;
using dojo.lib.Turtles;
using dojo.lib.Weapons;

namespace dojo.runner
{
    public static class Bootstrapper
    {
        public static IContainer Container;
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Dojo>().As<IDojo>();
            builder.RegisterType<NinjaTurtle>().As<INinjaTurtle>();

            builder.RegisterType<Anchovy>().As<IPizza>();
            builder.RegisterType<Sai>().As<IWeapon>();
            builder.RegisterType<Raphael>().As<ITurtleTraits>();

            builder.RegisterType<BeBop>().As<IFootClan>();

            //builder.RegisterType<DatabaseMySqlQuery>().As<IDatabaseMySqlQuery>();
            //builder.RegisterType<DatabaseSqlQuery>().As<IDatabaseSqlQuery>();

            //builder.RegisterType<TableMySqlQuery>().As<ITableMySqlQuery>();
            //builder.RegisterType<TableSqlQuery>().As<ITableSqlQuery>();

            //builder.RegisterType<ShardMySqlQuery>().As<IShardMySqlQuery>();
            //builder.RegisterType<ShardSqlQuery>().As<IShardSqlQuery>();

            //builder.RegisterType<ConnectionStringFactoryMySql>().As<IConnectionStringMySqlFactory>();
            //builder.RegisterType<ConnectionStringFactorySql>().As<IConnectionStringSqlFactory>();

            //builder.RegisterType<DoNotCacheManager>().As<ICacheManager>();
            //builder.RegisterType<KeyManager>().As<IKeyManager>();
            Container = builder.Build();
        }
    }
}