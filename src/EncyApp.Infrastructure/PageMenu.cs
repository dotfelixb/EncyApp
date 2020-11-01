/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Infrastructure
{
    public class PageMenu
    {
        public string Url { get; set; }
        public string Name { get; }
        public string Description { get; }
        public int Position { get; }

        public PageMenu(string url, string name, string description, int position)
        {
            Url = url;
            Name = name;
            Description = description;
            Position = position;
        }
    }
}
