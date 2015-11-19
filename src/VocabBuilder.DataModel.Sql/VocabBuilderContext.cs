using System.Data.Entity;
using VocabBuilder.Model;

namespace VocabBuilder.DataModel.Sql
{
    public class VocabBuilderContext:DbContext
    {
        public VocabBuilderContext() : base() { }
        public VocabBuilderContext(string connStr) : base(connStr) { }

        public DbSet<Word> Words { get; set; }
    }
}
