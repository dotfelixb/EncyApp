// Copyright (c) 2020 dotfelixb
// See License in the project root for license information.

namespace EncyApp.WebCore.Actions
{
    using ExtCore.Mvc.Infrastructure.Actions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Routing;
    using System;

    public class UseEndpointsAction : IUseEndpointsAction
    {
        public int Priority => 1000;

        public void Execute(IEndpointRouteBuilder endpointRouteBuilder, IServiceProvider serviceProvider)
        {
            endpointRouteBuilder.MapControllerRoute(
                name: "Default", 
                pattern: "{controller}/{action}", 
                defaults: new { controller = "Home", action = "Index" });
        }
    }
}
