using CQRS_Query.Core;
using System;
using System.Linq;
using System.Reflection;
using Unity;

namespace CQRS_Query
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IQueryBus, DefaultQueryBus>();
            // query processers generic dependency resolver
            RegisterQueryProcessers(container);
        }

        private static void RegisterQueryProcessers(IUnityContainer container)
        {
            var queryProcessers = Assembly.GetExecutingAssembly().GetTypes()
             .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryProcesser<,>)));

            foreach (var processer in queryProcessers)
            {
                foreach (var query in processer.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryProcesser<,>)).ToList())
                {
                    container.RegisterType(query, processer);
                }
            }
        }
    }
}