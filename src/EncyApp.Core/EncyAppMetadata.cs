﻿/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Core
{
    using System;
    using EncyApp.Infrastructure;
    using System.Collections.Generic;
    using ExtCore.Infrastructure;

    public class EncyAppMetadata : ExtensionBase, IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[]
        {
            new StyleSheet("/Styles.encyapp.ant.css", 200),
            new StyleSheet("/Styles.encyapp.core.css", 300)
        };

        public IEnumerable<Script> Scripts => new Script[] 
        {
            new Script("/Scripts.encyapp.core.js", 300)
        };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { new MenuItem("/", "Home", 100) };

        public IEnumerable<PageMenu> PageMenuItems => Array.Empty<PageMenu>();
    }
}