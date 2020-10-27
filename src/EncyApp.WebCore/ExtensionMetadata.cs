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
            new StyleSheet("//cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.css", 100),
            new StyleSheet("/Styles.encyapp.webcore.css", 200)
        };

        public IEnumerable<Script> Scripts => new Script[] {
            new Script("//code.jquery.com/jquery-3.1.1.min.js", 100),
            new Script("//cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.js", 200),
            new Script("/Scripts.encyapp.webcore.js", 300)
        };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { new MenuItem("/", "Home", 100) };
    }
}
