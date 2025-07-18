﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Service
{
    public class ServiceLocatorSingleton
    {
        private static readonly Lazy<ServiceLocatorSingleton> _lazy =
        new Lazy<ServiceLocatorSingleton>(() => new ServiceLocatorSingleton());

        private ServiceLocatorSingleton()
        {
            Console.WriteLine("Instance created");
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static ServiceLocatorSingleton Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

        public IServiceProvider ServiceProvider { get; set; }
    }
}
