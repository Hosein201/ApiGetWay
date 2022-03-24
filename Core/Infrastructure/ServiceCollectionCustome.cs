using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Infrastructure
{
    public static class ServiceCollectionCustome
    {
        /// <summary>
        /// GetScopedService
        /// </summary>
        /// <param name="typeOfAssembly"></param>
        public static List<Services> GetScopedService(Type typeOfAssembly)
        {
            return GetServices(typeOfAssembly, typeof(IScopedDependency));
        }

        /// <summary>
        /// GetTransientService
        /// </summary>
        /// <param name="typeOfAssembly"></param>
        public static List<Services> GetTransientService(Type typeOfAssembly)
        {
            return GetServices(typeOfAssembly, typeof(ITransientDependency));
        }

        /// <summary>
        /// GetSingletonService
        /// </summary>
        /// <param name="typeOfAssembly"></param>
        /// <returns></returns>
        public static List<Services> GetSingletonService(Type typeOfAssembly)
        {
            return GetServices(typeOfAssembly, typeof(ISingletonDependency));
        }

        private static List<Services> GetServices(Type typeOfAssembly, Type typeOfInterFace)
        {
            if (typeOfAssembly is null)
                throw new ArgumentNullException("type is null in method addScopedService");

            var servicesClass = Assembly.GetAssembly(typeOfAssembly)
                               .GetTypes()
                               .Where(w => 
                                       w.IsClass &&
                                      !w.IsAbstract &&
                                       w.IsPublic &&
                                       w.IsSubclassOf(typeOfInterFace)).ToList();

            List<Services> result = new();

            foreach (Type service in servicesClass)
            {
                var interFace = service.GetInterface($"I{service.Name}");
                if (interFace != null)
                    throw new ArgumentNullException($"this class {service.Name} has no interFace like name I{service.Name}");

                result.Add(new Services
                {
                    ClassType = service,
                    InterFaceType = interFace
                });
            }

            return result;
        }
    }
}
