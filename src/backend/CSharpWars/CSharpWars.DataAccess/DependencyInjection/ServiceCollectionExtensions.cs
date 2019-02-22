﻿using CSharpWars.DataAccess.Repositories;
using CSharpWars.DataAccess.Repositories.Interfaces;
using CSharpWars.Model;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpWars.DataAccess.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureDataAccess(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<CSharpWarsDbContext>();
            serviceCollection.AddScoped<IRepository<Player>, PlayerRepository>();
        }
    }
}