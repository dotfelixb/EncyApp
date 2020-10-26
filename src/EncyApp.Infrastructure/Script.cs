// Copyright (c) 2020 dotfelixb
// See License in the project root for license information.

namespace EncyApp.Infrastructure
{
    public class Script
    {
        public string Url { get; set; }
        public int Position { get; }

        public Script(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}