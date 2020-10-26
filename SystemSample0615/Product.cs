using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSample0615
{
    //商品クラス
    class Product
    {
        //商品コード
        public int Code { get; set; } //自動実装プロパティ
        //商品名
        public string Name { get; set; }
        //商品価格
        private int Price { get; set; }

        //消費税の価格を求める
        public int GetTax()
        {
            return(int)( Price * 0.1);
        }

        //税込み価格を求める
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }

        //コンストラクタ
        public Product(int code,string name,int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }


    }
}
