using CQRS.Framework.Command;
using CQRS.Framework.Event;
using System;
using System.Linq;
using System.Reflection;
using Unity;

namespace CQRS.Sample
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

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICommandBus, DefaultCommandBus>();
            container.RegisterType<IEventBus, DefaultEventBus>();
            RegisterCommandHandlers(container);
            RegisterEventSubscribers(container);
        }

        private static void RegisterCommandHandlers(IUnityContainer container)
        {
            var commandHandlers = Assembly.GetExecutingAssembly().GetTypes()
             .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)));

            foreach (var handler in commandHandlers)
            {
                foreach (var command in handler.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)).ToList())
                {
                    container.RegisterType(command, handler);
                }
            }
        }

        private static void RegisterEventSubscribers(IUnityContainer container)
        {
            var eventSubscribers = Assembly.GetExecutingAssembly().GetTypes()
             .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEventHandler<>)));

            foreach (var subscriber in eventSubscribers)
            {
                foreach (var eve in subscriber.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEventHandler<>)).ToList())
                {
                    container.RegisterType(eve, subscriber);
                }
            }
        }
    }
}