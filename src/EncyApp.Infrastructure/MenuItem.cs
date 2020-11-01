/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Infrastructure
{
    public class MenuItem
    {
        public string Url { get; set; }
        public string Name { get; }
        public int Position { get; }

        public MenuItem(string url, string name, int position)
        {
            Url = url;
            Name = name;
            Position = position;
        }
    }
}