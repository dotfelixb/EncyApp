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

    public class PageMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ss = new List<PageMenu>();

            foreach (IExtensionMetadata em in ExtensionManager.GetInstances<IExtensionMetadata>())
            {
                ss.AddRange(em.PageMenuItems);
            }

            var vm = ss.OrderBy(o => o.Position)
                .Select(s => new PageMenuViewModel { Name = s.Name, Description = s.Description, Url = s.Url });

            return View(vm);
        }
    }
}
