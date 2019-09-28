using System;
using System.Collections.Generic;

namespace LottoGenerator.RandomNumbers
{
    public class LottoNumbers : IRandomNumbers
    {
        public List<int> RandomNumbers
        {
            get
            {
                List<int> lottoNumbers = new List<int>();
                Random rnd = new Random();
                
                while (lottoNumbers.Count < 6)
                {
                    int nextLottoNumber = rnd.Next(1, 49);

                    if (!lottoNumbers.Contains(nextLottoNumber))
                    {
                        lottoNumbers.Add(nextLottoNumber);
                    }
                }
                
                lottoNumbers.Sort();

                return lottoNumbers;
            }
        }
    }
}