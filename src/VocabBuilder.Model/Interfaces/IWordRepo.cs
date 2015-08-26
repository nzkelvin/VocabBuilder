using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabBuilder.Model.Interfaces
{
    public interface IWordRepo
    {
        IEnumerable<Word> GetWords();
    }
}
