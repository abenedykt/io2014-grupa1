using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class CalculateBasketNode : IReceiptNode
    {
        private IReceiptNode _nextNode;

        public double Calculate(IList<IOrder> orders)
        {
            return orders.Sum(x => x.Product.Cost * x.Quantity);
        }


        public bool HasNext()
        {
            return _nextNode != null;
        }

        public IReceiptNode Next
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }
    }

    public class ProductTypeDiscount : IReceiptNode, IProductTypeDiscount
    {
        private double _amount;
        private ProductType _productType;
        private IReceiptNode _nextNode;

        public double Amount
        {
            get { return _amount; }
        }

        public ProductType ProductType
        {
            get { return _productType; }
        }

        public ProductTypeDiscount(double amount, ProductType productType)
        {
            _amount = amount;
            _productType = productType;
        }

        public bool HasNext()
        {
            return _nextNode != null;
        }

        public double Calculate(IList<IOrder> orders)
        {
            foreach (var order in orders)
            {
                if (order.Product.ProductType == _productType)
                {
                    order.Product.Cost -= (order.Product.Cost * Amount);
                }
            }
            return 0;
        }

        public IReceiptNode Next
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }
    }

    public class VatTax : IReceiptNode, ITax
    {
        private double _amount;
        private IReceiptNode _nextNode;

        public double Amount
        {
            get { return _amount; }
        }

        public VatTax(double amount)
        {
            _amount = amount;
        }

        public bool HasNext()
        {
            return _nextNode != null;
        }

        public double Calculate(IList<IOrder> orders)
        {
            var sum = orders.Sum(x => x.Product.Cost * x.Quantity);
            return -(sum * _amount);
        }

        public IReceiptNode Next
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }
    }

    public class BasketSumDiscount : IReceiptNode, IBasketDiscount
    {
        private double _amount;
        private double _limit;
        private IReceiptNode _nextNode;
        public double Amount
        {
            get { return _amount; }
        }

        public double BasketLimit
        {
            get { return _limit; }
        }

        public BasketSumDiscount(double amount, double limit)
        {
            _amount = amount;
            _limit = limit;
        }

        public bool HasNext()
        {
            return _nextNode != null;
        }

        public double Calculate(IList<IOrder> orders)
        {
            var orderSum = orders.Sum(x => x.Product.Cost * x.Quantity);
            if (orderSum > _limit)
            {
                return -(orderSum * _amount);
            }
            return 0;
        }

        public IReceiptNode Next
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }
    }


    public interface IReceiptNode
    {
        IReceiptNode Next { get; set; }
        bool HasNext();
        double Calculate(IList<IOrder> orders);
    }

    public interface ITax
    {
        double Amount { get; }
    }

    public interface IProductTypeDiscount
    {
        double Amount { get; }
        ProductType ProductType { get; }
    }

    public interface IBasketDiscount
    {
        double BasketLimit { get; }
        double Amount { get; }
    }
}
