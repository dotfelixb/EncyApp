/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Invoice.Web
{
    using EncyApp.Infrastructure;
    using ExtCore.Infrastructure;
    using System.Collections.Generic;
    public class InvoiceMetadata : ExtensionBase, IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };

        public IEnumerable<PageMenu> PageMenuItems =>  new PageMenu[]  
        {
            new PageMenu ("/invoice", 
                "Invoice", 
                "Ablity to manage your invoice and track payment is vital to any company, this tool gives you that power", 
                300)
        };
    }
}