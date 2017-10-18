using System.Collections.ObjectModel;

namespace VM.Logic
{
    public interface IBag
    {
        ObservableCollection<CoinType> Coins { get; set; }

        void Minus(CoinType coinType);
        void Plus(CoinType coinType);
 
    }
}