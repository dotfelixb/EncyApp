/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Customer.Web
{
    using EncyApp.Infrastructure;
    using ExtCore.Infrastructure;
    using System;
    using System.Collections.Generic;

    public class CustomerMetadata : ExtensionBase, IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => Array.Empty<StyleSheet>();

        public IEnumerable<Script> Scripts => Array.Empty<Script>();

        public IEnumerable<MenuItem> MenuItems => Array.Empty<MenuItem>();

        public IEnumerable<PageMenu> PageMenuItems => new PageMenu[]
        {
            new PageMenu ("/customer",
                "Customer",
                "Ency CRM lets you manage you customers putting you close to their business needs",
                200)
        };
    }
}