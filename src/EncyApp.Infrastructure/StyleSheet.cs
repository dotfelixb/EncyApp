/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.Infrastructure
{
    public class StyleSheet
    {
        public string Url { get; set; }
        public int Position { get; }

        public StyleSheet(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}