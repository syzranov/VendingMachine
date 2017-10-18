using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace VM.Logic
{
    public static class PocketExt
    {
        public static List<CoinType> SummToCoins(this int coins)
        {
            var result = new List<CoinType>();
            SummToCoins(ref result, coins, CoinType.Ten);
            return result;
        }

        private static void SummToCoins(ref List<CoinType> result, int money, CoinType? coinType)
        {
            if (money > 0 && coinType != null)
            {
                if ((int)coinType <= money)
                {
                    var res1 = money / (int)coinType;
                    if (res1 > 0)
                    {
                        for (int i = 0; i < res1; i++)
                        {
                            result.Add((CoinType)coinType);
                        }
                    }
                    money = money % (int)coinType;
                }
                SummToCoins(ref result, money, coinType.Next());
            }
        }

        public static int Summ(this ObservableCollection<CoinType> coins)
        {
            return coins.Sum(x => (int)x);
        }

        public static int SummByCoinType(this ObservableCollection<CoinType> coins, CoinType coinType)
        {
            return coins.Where(y => y == coinType).Sum(x => (int)x);
        }

        public static int CountByCoinType(this ObservableCollection<CoinType> coins, CoinType coinType)
        {
            return coins.Count(y => y == coinType);
        }
    }
}