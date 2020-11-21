/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.AssetManagement.Web
{
    using EncyApp.Infrastructure;
    using System.Collections.Generic;
    public class AssetsMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };

        public IEnumerable<PageMenu> PageMenuItems => new PageMenu[]
        {
            new PageMenu ("/asset", 
                "Asset Management", 
                "Manage your asset with Ency comprehensive Asset Management tool", 
                100)
        };
    }
}
