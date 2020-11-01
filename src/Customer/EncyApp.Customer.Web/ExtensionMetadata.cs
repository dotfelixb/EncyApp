using EncyApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyApp.Customer.Web
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };

        public IEnumerable<PageMenu> PageMenuItems => new PageMenu[]
        {
            new PageMenu ("/customer", 
                "Customer", 
                "Ency CRM lets you manage you customers putting you close to their business needs", 
                200)
        };
    }
}
