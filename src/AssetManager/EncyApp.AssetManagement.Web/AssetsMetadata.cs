/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.AssetManagement.Web
{
    using EncyApp.Infrastructure;
    using ExtCore.Infrastructure;
    using System;
    using System.Collections.Generic;

    public class AssetsMetadata : ExtensionBase, IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => Array.Empty<Script>();

        public IEnumerable<MenuItem> MenuItems => Array.Empty<MenuItem>();

        public IEnumerable<PageMenu> PageMenuItems => new PageMenu[]
        {
            new PageMenu ("/asset",
                "Asset Management",
                "Manage your asset with Ency comprehensive Asset Management tool",
                100)
        };
    }
}