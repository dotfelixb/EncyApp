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

    public class StylesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var ss = new List<StyleSheet>();

            foreach (var em in ExtensionManager.GetInstances<IExtensionMetadata>())
            {
                ss.AddRange(em.StyleSheets);
            }

            var vm = ss.OrderBy(o => o.Position)
                .Select(s => new StyleSheetViewModel { Url = s.Url });

            return View(vm);
        }
    }
}