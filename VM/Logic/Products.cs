using System.Collections.Generic;

namespace VM.Logic
{
    public class Products
    {
        public static readonly Products Identity = new Products();

        public List<ProductItem> List { get; set; }
    }
}