using System;
using System.Collections.Generic;
using LottoGenerator.RandomNumbers;

namespace LottoGenerator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {

#if DEBUG
            #region Functional-Main
            // Functional:
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

            Program.SelectionSort(ref lottoNumbers);
            
            for (int i = 0; i < 6; i++)
            {
                Console.Write(lottoNumbers[i] + " ");
            }
            #endregion Functional-Main
#else

            #region OOP-Main
            // OOP:
            IRandomNumbers randomNumbers = new LottoNumbers();

            List<int> lottoNumbers = randomNumbers.RandomNumbers;
            
            foreach (int number in lottoNumbers)
            {
                Console.Write(number + " ");
            }
            #endregion OOP-Main
#endif

            Console.Write("\nEnd");
            Console.ReadKey();
        }
        
        #region Functional
        
        // Functional:
        private static void SelectionSort(ref List<int> feld)
        {
            for (int i = 0; i < feld.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < feld.Count; j++)
                    if (feld[j] < feld[min])
                        min = j;
                
                int tmp = feld[min];
                feld[min] = feld[i];
                feld[i] = tmp;
            }
        }
        #endregion
    }
}