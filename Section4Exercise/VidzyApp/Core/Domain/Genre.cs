using System.Collections.Generic;

namespace VidzyApp.Core.Domain
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Video> Videos { get; set; }
    }
}