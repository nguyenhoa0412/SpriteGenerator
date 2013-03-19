using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteGenerator
{
    public class SpriteItem
    {
        public SpriteItem()
        {
            Source = "";
            Name = "";
        }
        public string Source { get; set; }
        public string Name { get; set; }
    }
}
