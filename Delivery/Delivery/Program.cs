using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class ReceiptService
    {
        private IList<IOrder> _orders;
        private IReceiptNode _node;
        public ReceiptService(IReceiptNode calculateStartNode, IList<IOrder> orders)
        {
            _orders = orders;
            _node = calculateStartNode;
        }

        public double CaclulateReceipt()
        {
            double sum = 0d;
            while (_node.HasNext())
            {
                sum += _node.Calculate(_orders);
                if (_node.HasNext()) _node = _node.Next;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Product("Wiedźmin cz1", 80, ProductType.Book);
            var comicBook = new Product("Batman: Smierc rodziny", 100, ProductType.ComicBook);

            var basket = new Basket();
            basket.AddProduct(book, 2);
            basket.AddProduct(comicBook, 3);

            var calcBasket = new CalculateBasketNode();
            var vat = new VatTax(0.22);
            var prodTypeDiscount = new ProductTypeDiscount(0.5, ProductType.Book);
            var basketDiscount = new BasketSumDiscount(0.1, 200);
            prodTypeDiscount.Next = calcBasket;
            calcBasket.Next = vat;
            vat.Next = basketDiscount;

            var recipeService = new ReceiptService(prodTypeDiscount, basket.GetOrders());
            var cost = recipeService.CaclulateReceipt();
            Console.WriteLine("Your recipe cost: {0}", cost);
        }
    }
}
