/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Core
{
    using ExtCore.Infrastructure.Actions;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class ConfigureServiceAction : IConfigureServicesAction
    {
        public int Priority => 100;

        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddAntDesign();
        }
    }
}