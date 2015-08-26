using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabBuilder.Model;
using VocabBuilder.Model.Interfaces;

namespace VocabBuilder.DataModel.Sql
{
    public class WordRepo : IWordRepo
    {
        private VocabBuilderContext _context;

        public WordRepo()
        {
            _context = new VocabBuilderContext();
        }

        public IEnumerable<Model.Word> GetWords()
        {
            var words = _context.Words.Select(w => w);

            foreach(var w in words)
            {
                yield return new Word() { Id = w.Id, Text = w.Text };
            }
        }
    }
}
