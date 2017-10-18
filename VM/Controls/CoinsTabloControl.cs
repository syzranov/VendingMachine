using System.Windows.Forms;
using VM.Logic;

namespace VM.Controls
{
    public partial class CoinsTabloControl : UserControl
    {
        public CoinsTabloControl()
        {
            InitializeComponent();
            TempPocket.Instance.Coins.CollectionChanged += Coins_CollectionChanged;
        }

        void Coins_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            lTablo.Text = TempPocket.Instance.Coins.Summ().ToString();
        }

        private void CoinsTabloControl_Load(object sender, System.EventArgs e)
        {

        }
    }
}
