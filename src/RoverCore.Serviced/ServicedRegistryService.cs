using System;
using System.Collections.Generic;
using System.Text;

namespace RoverCore.Serviced
{
    /// <summary>
    /// This service maintains a list of registered service types from Serviced
    /// </summary>
    public class ServicedRegistryService
    {
        public List<Type> ServiceTypes { get; set; } = new List<Type>();
    }
}
