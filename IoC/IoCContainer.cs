using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BasketApp.IoC
{

    /// <summary>
    /// A shorthand access class to get DI services with nice clean code
    /// </summary>
    public static class IoC
    {

        /// <summary>
        /// The scoped instance of the <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext =>
            IoCContainer.Provider.GetService<ApplicationDbContext>();
    }


    /// <summary>
    /// The dependency injection container making use of the built in .net core service provider
    /// </summary>
    public static class IoCContainer
    {

        /// <summary>
        /// The service provider fot this application
        /// </summary>
        public static ServiceProvider Provider { get; set; }  
    }
}
