using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSample0615
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];

            products[0] = new Product(123, "かりんとう", 180);
            products[1] = new Product(124, "枝豆", 130);
            products[2] = new Product(125, "プリン", 210);
            products[3] = new Product(126, "パフェ", 450);
            products[4] = new Product(127, "焼き鳥", 160);

            //商品名と税込み価格を表示する
            //かりんとう：198円
            /*Console.WriteLine("{0}:{1}円",karinto.Name , karinto.GetPriceIncludingTax());
            Console.WriteLine("{0}:{1}円", edamame.Name, edamame.GetPriceIncludingTax());
            Console.WriteLine("{0}:{1}円", purin.Name, purin.GetPriceIncludingTax());
            Console.WriteLine("{0}:{1}円", pafe.Name, pafe.GetPriceIncludingTax());
            Console.WriteLine("{0}:{1}円", yakitori.Name, yakitori.GetPriceIncludingTax());
            */
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("{0}:{1}円", products[i].Name, products[i].GetPriceIncludingTax());
            }


        }
    }
}
