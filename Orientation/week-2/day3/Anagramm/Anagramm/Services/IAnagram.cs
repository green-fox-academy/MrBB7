using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public interface IAnagram
    {
        bool IsAnagram();
        void AnagramChecker(string inputWord);
    }
}
