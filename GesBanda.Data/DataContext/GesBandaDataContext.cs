using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesBanda.Data.Models;

namespace GesBanda.Data.DataContext
{
    public class GesBandaDataContext : DbContext, IGesBandaDataContext
    {
        public GesBandaDataContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<SCO_Attributes> Attributes { get; set; }
        public DbSet<SCO_Composer> Composers { get; set; }
        public DbSet<SCO_Genre> Genres { get; set; }
        public DbSet<SCO_Score_Parts> ScoreParts { get; set; }
        public DbSet<SCO_Scores> Scores { get; set; }
        public DbSet<SCO_Scores_Attributes> ScoresAttributes { get; set; }

    }
}
