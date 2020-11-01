/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Infrastructure
{
    using System.Collections.Generic;

    public interface IExtensionMetadata
    {
        IEnumerable<StyleSheet> StyleSheets { get; }
        IEnumerable<Script> Scripts { get; }
        IEnumerable<MenuItem> MenuItems { get; }
        IEnumerable<PageMenu> PageMenuItems { get; }
    }
}
