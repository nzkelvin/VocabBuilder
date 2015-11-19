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

        public WordRepo(string connStr)
        {
            _context = new VocabBuilderContext(connStr);
        }

        public IEnumerable<Model.Word> GetWords()
        {
            var words = _context.Words.Select(w => w);

            foreach(var w in words)
            {
                yield return new Word() { Id = w.Id, Text = w.Text };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Number of records added</returns>
        public int AddWord(Word word)
        {
            _context.Words.Add(word);

            return _context.SaveChanges();
        }
    }
}
