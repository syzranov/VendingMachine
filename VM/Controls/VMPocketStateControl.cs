using System.Windows.Forms;
using VM.Logic;

namespace VM.Controls
{
    public partial class VMPocketStateControl : UserControl
    {
        private readonly string mask = "Баланс: {0} руб.";
        public VMPocketStateControl()
        {
            InitializeComponent();
            VMPocket.Instance.Coins.CollectionChanged += Coins_CollectionChanged;
            InitGrid();
            ShowSumm();
        }

        void Coins_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            InitGrid();
            ShowSumm();

        }

        private void ShowSumm()
        {
            labelSumm.Text =
                string.Format(mask,
                    VMPocket.Instance.Coins.Summ());
        }
        private void InitGrid()
        {
            dgvMain.Rows.Clear();

            AddRow(CoinType.Ten);
            AddRow(CoinType.Five);
            AddRow(CoinType.Two);
            AddRow(CoinType.One);
        }

        private void AddRow(CoinType coin)
        {
            dgvMain.Rows.Add(new object[]
            {
                ((int)coin).ToString(), 
                VMPocket.Instance.Coins.CountByCoinType(coin),
                VMPocket.Instance.Coins.SummByCoinType(coin)
            });
        }
    }
}
