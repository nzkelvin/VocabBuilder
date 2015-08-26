using System.Data.Entity;
using VocabBuilder.Model;

namespace VocabBuilder.DataModel.Sql
{
    public class VocabBuilderContext:DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}
