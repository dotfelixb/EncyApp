// Copyright (c) 2020 dotfelixb
// See License in the project root for license information.

namespace EncyApp.WebCore
{
    using EncyApp.Infrastructure;
    using System.Collections.Generic;

    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[]
        {
            new StyleSheet("/Styles.encyapp.webcore.css", 100)
        };

        public IEnumerable<Script> Scripts => new Script[] {
            new Script("/Scripts.encyapp.webcore.js", 100)
        };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { new MenuItem("/", "Home", 100) };
    }
}
