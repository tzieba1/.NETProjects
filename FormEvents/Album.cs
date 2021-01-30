using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormEvents
{
    /// <summary>
    /// Class to Hold Albums
    /// </summary>
    
    class Album
    {
        public string Description { get; private set;}
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public Image Cover { get; private set; }

        public Album(string artist, string title, string filename, string description)
        {
            Title = title;
            Artist = artist;
            Cover = Image.FromFile(filename);
            Description = description;
        }
    }
}
