﻿using Business.Abstracts;
using Business.Concretes;
using Core.CrossCuttingConcerns.Rules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

            services.AddScoped<IApplicantService, ApplicantManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IApplicationStateService, ApplicationStateManager>();
            services.AddScoped<IBootcampService, BootcampManager>();
            services.AddScoped<IBootcampStateService, BootcampStateManager>();
            services.AddScoped<IBlacklistService, BlacklistManager>();

            return services;
        }


        public static IServiceCollection AddSubClassesOfType
        (this IServiceCollection services, Assembly assembly,
        Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (Type? item in types)
            {
                if (addWithLifeCycle == null) { services.AddScoped(item); }
                else { addWithLifeCycle(services, type); }
            }
            return services;
        }
    }
}
