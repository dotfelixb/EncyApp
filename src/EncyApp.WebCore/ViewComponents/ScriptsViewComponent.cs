﻿/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.WebCore.ViewComponents
{
    using EncyApp.Infrastructure;
    using EncyApp.WebCore.ViewModel;
    using ExtCore.Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ScriptsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ss = new List<Script>();

            foreach (IExtensionMetadata em in ExtensionManager.GetInstances<IExtensionMetadata>())
            {
                ss.AddRange(em.Scripts);
            }

            var vm = ss.OrderBy(o => o.Position)
                .Select(s => new ScriptViewModel { Url = s.Url });

            return View(vm);
        }
    }
}