using System;
using System.Reflection;
using System.Collections.Generic;
using Flexybox_project.Models;

namespace Flexybox_project
{
    public class InstanceService
    {
        public IEnumerable<Vehicle> GetInstances()
        {
            List<Vehicle> instances = new List<Vehicle>();
            Car c = new Car();
            Bicycle b = new Bicycle();
            Train t = new Train();
            instances.Add(c);
            instances.Add(b);
            instances.Add(t);

            return instances;
        }
    }
}