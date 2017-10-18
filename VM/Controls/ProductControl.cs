using System.Drawing;
using System.Windows.Forms;
using VM.Logic;

namespace VM.Controls
{
    public partial class ProductControl : UserControl
    {
        private const string PriceMask = "{0} руб";
        private const string LeftMask = "Осталось {0} шт.";

        public ProductControl(ProductItem product)
        {
            InitializeComponent();

            Img = product.Img;
            Price = product.Price;
            Value = product.Value;
            Caption = product.Name;
        }
        public ProductControl()
        {
            InitializeComponent();
        }

        public Image Img 
        {
            set
            {
                pictureBoxMain.Image = value;
            } 
        }

        public Button BuyButton { get { return buttonBuy; } }

        private int _price;
        public int Price
        {
            set
            {
                _price = value;
                labelPrice.Text = string.Format(PriceMask, value);
            }
            get
            {
                return _price;
            }
        }
        public string Caption
        {
            set
            {
                labelProductName.Text = value;
            }
        }

        private int _value;
        public int Value
        {
            set
            {
                _value = value;
                labelLeft.Text = string.Format(LeftMask, value);
            }
            get
            {
                return _value;
            }
        }
    }
}
