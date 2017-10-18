using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using VM.Logic;
using VM.Properties;

namespace VM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // default initialization of money and products bag
            InitTempBag();
            InitUserBag();
            InitVMBag();
            InitProductList();

            Application.Run(new MainForm());
        }


        private static void InitProductList()
        {
            Products.Identity.List = new List<ProductItem>();

            var t = new ProductItem
            {
                Value = 20, 
                Price = 18, 
                Name = "Кофе", 
                Img = Resources.cafe
            };
            Products.Identity.List.Add(t);

            t = new ProductItem
            {
                Value = 10,
                Price = 13,
                Name = "Чай",
                Img = Resources.tea
            };
            Products.Identity.List.Add(t);

            t = new ProductItem
            {
                Value = 20,
                Price = 21,
                Name = "Латте",
                Img = Resources.latte
            };
            Products.Identity.List.Add(t);

            t = new ProductItem
            {
                Value = 15,
                Price = 35,
                Name = "Сок",
                Img = Resources.juice
            };
            Products.Identity.List.Add(t);
        }

        private static void InitTempBag()
        {
            TempPocket.Instance.Coins = new ObservableCollection<CoinType>();
        }


        //
        // В будущем можно переписать загрузки данных по умолчанию
        // из БД или XML
        //

        /*
         * Система показывает кошелек VM для сдачи (кол-во монет разного достоинства)
         *  1 руб = 100 штук (начальные данные)
         *  2 руб = 100 штук
         *  5 руб = 100 штук
         *  10 руб = 100 штук
         */
        private static void InitVMBag()
        {
            VMPocket.Instance.Coins = new ObservableCollection<CoinType>();
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                VMPocket.Instance.Coins.Add(CoinType.One);
            }
            for (i = 0; i < 100; i++)
            {
                VMPocket.Instance.Coins.Add(CoinType.Two);
            }
            for (i = 0; i < 100; i++)
            {
                VMPocket.Instance.Coins.Add(CoinType.Five);
            }
            for (i = 0; i < 100; i++)
            {
                VMPocket.Instance.Coins.Add(CoinType.Ten);
            }
        }



        /**
         * Система показывает кошелек пользователя (кол-во монет разного достоинства)
         *   1 руб = 10 штук (начальные данные)
         *   2 руб = 30 штук
         *   5 руб = 20 штук
         *   10 руб = 15 штук
         */
        private static void InitUserBag()
        {
            UserPocket.Instance.Coins = new ObservableCollection<CoinType>();
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                UserPocket.Instance.Coins.Add(CoinType.One);
            }
            for (i = 0; i < 30; i++)
            {
                UserPocket.Instance.Coins.Add(CoinType.Two);
            }
            for (i = 0; i < 20; i++)
            {
                UserPocket.Instance.Coins.Add(CoinType.Five);
            }
            for (i = 0; i < 15
                ; i++)
            {
                UserPocket.Instance.Coins.Add(CoinType.Ten);
            }
        }
    }
}
