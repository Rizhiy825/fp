﻿using System.Collections.Generic;

namespace TagsCloud.Interfaces
{
    public interface IWordsFrequencyAnalyzer
    {
        public SortedDictionary<int, List<string>> GetSortedDictOfWordsFreq(IEnumerable<string> normalFormWords);
    }
}