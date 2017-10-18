using System;
using System.Windows.Forms;
using VM.Controls;
using VM.Logic;

namespace VM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitProducts();
        }

        private void InitProducts()
        {
            foreach (var item in Products.Identity.List)
            {
                var p = new ProductControl(item);
                p.BuyButton.Click += BuyButton_Click;
                flpMain.Controls.Add(p);
            }
        }

        void BuyButton_Click(object sender, EventArgs e)
        {
            var control = (ProductControl)((Button) sender).GetContainerControl();
            // ReSharper disable once PossibleNullReferenceException
            if (control.Value == 0)
            {
                MessageBox.Show(@"К сожалению, выбранный напиток закончился, попробуйте что-нибудь другое.",
                   @"Приготовление напитка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            } 
            else if(TempPocket.Instance.Coins.Summ() >= control.Price)
            {
                TempPocket.Instance.Buy(control.Price);
                control.Value = control.Value - 1;

                MessageBox.Show(@"Ваш напиток готов!",
                   @"Приготовление напитка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Не достаточно средств",
                   @"Приготовление напитка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
