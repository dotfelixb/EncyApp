/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Core
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    public class ConfigureServiceAction : ExtCore.Infrastructure.Actions.IConfigureServicesAction
    {
        public int Priority => 100;

        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }
    }
}
