/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Core.ViewComponents
{
    using EncyApp.Core.ViewModel;
    using EncyApp.Infrastructure;
    using ExtCore.Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ss = new List<MenuItem>();

            foreach (IExtensionMetadata em in ExtensionManager.GetInstances<IExtensionMetadata>())
            {
                ss.AddRange(em.MenuItems);
            }

            var vm = ss.OrderBy(o => o.Position)
                .Select(s => new MenuViewModel { Name = s.Name, Url = s.Url });

            return View(vm);
        }
    }
}
