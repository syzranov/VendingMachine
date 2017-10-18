using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VM.Logic;

namespace VM.Controls
{
    public partial class UserPocketControl : UserControl
    {
        private const string BallansMask = "Баланс {0} руб.";
        private const string ButtonMask = "{0} руб.({1} шт.{2} руб.)";
        private const int ButtonHeight = 40;
        private const string MsgCoinIsEmpty = "Монеты номиналом: {0} руб. - закончились!";
        private const string ButtonFontFamily = "Microsoft Sans Serif";
        private const float ButtonFontSize = 10;

        public UserPocketControl()
        {
            InitializeComponent();
            UserPocket.Instance.Coins.CollectionChanged += Bag_CollectionChanged;
            InitUserBag();
            ShowBalans();
        }

        void Bag_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (var control in MainPanel.Controls)
            {
                if (control is Button)
                {
                    var ct = (CoinType)(control as Button).Tag;
                    ((Button) control).Text = GetTextByCoinType(ct);
                }
            }
            
            ShowBalans();
        }

        private void InitUserBag()
        {
            AddButton(CoinType.One);
            AddButton(CoinType.Two);
            AddButton(CoinType.Five);
            AddButton(CoinType.Ten);
            ShowBalans();
        }

        private string GetTextByCoinType(CoinType coinType)
        {
            var count = UserPocket.Instance.Coins.CountByCoinType(coinType);

            return string.Format(ButtonMask,
                (int) coinType,
                count,
                count*(int) coinType);
        }
        private void AddButton(CoinType coinType)
        {
            var button = new Button
            {
                Text = GetTextByCoinType(coinType),
                Dock = DockStyle.Top,
                Font = new Font(ButtonFontFamily, ButtonFontSize),
                Height = ButtonHeight
            };

            button.Click += btn_Click;
            button.Tag = coinType;
            MainPanel.Controls.Add(button);
        }

        private void ShowBalans()
        {
            labelSumm.Text = string.Format(BallansMask,
                UserPocket.Instance.Coins.Summ());
        }

        void btn_Click(object sender, EventArgs e)
        {
            var coin = (CoinType)((Button)sender).Tag;
            if(UserPocket.Instance.Coins.Any(x => x == coin))
            {
                UserPocket.Instance.Minus(coin);
                TempPocket.Instance.Plus(coin);
            }
            else
            {
                MessageBox.Show(
                    string.Format(MsgCoinIsEmpty,
                    (int)coin));
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TempPocket.Instance.Coins.Count; i++)
            {
                UserPocket.Instance.Coins.Add(TempPocket.Instance.Coins[i]);
            }
            TempPocket.Instance.Coins.Clear();
        }
    }
}
