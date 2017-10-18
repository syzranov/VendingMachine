using System.Collections.ObjectModel;
using System.Linq;


namespace VM.Logic
{
    public class Pocket : IBag
    {
        public Pocket()
        {
            Coins = new ObservableCollection<CoinType>();
        }
        public ObservableCollection<CoinType> Coins { get; set; }

        public void Minus(CoinType coinType)
        {
            var c = Coins.FirstOrDefault(x => x == coinType);
            Coins.Remove(c);
        }
        public void Plus(CoinType coinType)
        {
            Coins.Add(coinType);
        }

        public void Buy(int summ)
        {
            var left = Coins.Summ() - summ;
            // Все деньги кидаем в VM
            foreach (var coinType in Coins)
            {
                VMPocket.Instance.Plus(coinType);
            }
            TempPocket.Instance.Coins.Clear();

            // Рассчитываем сдачу
            var leftCoins = left.SummToCoins();
            foreach (var leftCoin in leftCoins)
            {
                VMPocket.Instance.Minus(leftCoin);
                TempPocket.Instance.Plus(leftCoin);
            }
        }
    }
}