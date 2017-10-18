namespace VM.Logic
{
    public static class CoinTypeExt
    {
        public static CoinType? Next(this CoinType? coin)
        {
            if (coin == null)
                return null;
            if (coin == CoinType.Ten)
                return CoinType.Five;
            if (coin == CoinType.Five)
                return CoinType.Two;
            if (coin == CoinType.Two)
                return CoinType.One;
            return null;
        }
    }
}