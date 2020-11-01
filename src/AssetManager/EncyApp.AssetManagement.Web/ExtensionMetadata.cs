﻿using EncyApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyApp.AssetManagement.Web
{
    public class ExtensionMetadata : IExtensionMetadata
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