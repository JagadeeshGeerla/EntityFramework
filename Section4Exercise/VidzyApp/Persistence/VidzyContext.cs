using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidzyApp.Core.Domain;

namespace VidzyApp.Persistence
{
    public class VidzyContext:DbContext
    {
        public VidzyContext():base("name=VidzyContext")
        {

        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
