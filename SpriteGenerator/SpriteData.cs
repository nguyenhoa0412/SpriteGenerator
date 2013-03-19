using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteGenerator
{
    [Serializable]
    public class SpriteData
    {
        public SpriteData()
        {
            SpriteItems = new List<SpriteItem>();
        }
        public int ItemWidth { get; set; }
        public int ItemHeight { get; set; }
        public int ColumnCount { get; set; }
        public string OutputFolderName { get; set; }
        public string ImagesFolderName { get; set; }
        public string IconClassName { get; set; }
        public string SpriteImageName { get; set; }
        public List<SpriteItem> SpriteItems { get; set; }
    }
}
