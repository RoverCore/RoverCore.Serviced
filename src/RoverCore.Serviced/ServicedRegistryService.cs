using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoverCore.Serviced
{
    /// <summary>
    /// This service maintains a list of registered service types from Serviced
    /// </summary>
    public class ServicedRegistryService
    {
        public List<Type> ServiceTypes { get; set; } = new List<Type>();

        /// <summary>
        /// Returns a subset of the registered Service Types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IEnumerable<Type> FilterServiceTypes<T>()
        {
            Type serviceType = typeof(T);

            if (serviceType.IsInterface || serviceType.IsClass)
                return ServiceTypes.Where(t => serviceType.IsAssignableFrom(t));

            return new List<Type>();
        }
    }
}
