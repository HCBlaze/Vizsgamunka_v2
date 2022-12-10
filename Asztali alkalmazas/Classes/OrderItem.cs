using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazas.Classes
{
    internal class OrderItem
    {
        public int Id { get; private set; }
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }



        public OrderItem()
        {

        }

        public OrderItem(int id, int orderid, int productid, decimal unitprice, int quantity)
        {
            this.Id = id;
            this.OrderId = orderid;
            this.ProductId = productid;
            this.UnitPrice = unitprice;
            this.Quantity = quantity;
        }
        public void setId(int id)
        {
            Id = _setID(id);
        }
        private int _setID(int i)
        {
            int _id = i;
            return _id;
        }

        public void setOrderId(int id)
        {
            Id = _setOrderId(id);
        }
        private int _setOrderId(int i)
        {
            int _id = i;
            return _id;
        }

        public void setProductId(int id)
        {
            Id = _setProductId(id);
        }
        private int _setProductId(int i)
        {
            int _id = i;
            return _id;
        }

        public void setUnitPrice(decimal price)
        {
            UnitPrice = _setUnitPrice(price);
        }

        private decimal _setUnitPrice(decimal price)
        {
            decimal _price = price;

            return _price;
        }

        public void setQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public int _setQuantity(int quantity)
        {
            return quantity;
        }
    }
}
