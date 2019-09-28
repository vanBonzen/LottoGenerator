using System.Collections.Generic;

namespace LottoGenerator.RandomNumbers
{
    public interface IRandomNumbers
    {
        List<int> RandomNumbers { get; }
    }
}