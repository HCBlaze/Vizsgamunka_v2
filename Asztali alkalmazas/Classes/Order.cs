﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazas.Classes
{
    internal class Order
    {
        public int Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string OrderNumber { get; private set; }
        public int CustomerId { get; private set; }
        public decimal TotalAmount { get; private set; }



        public Order()
        {

        }

        public Order(int id, DateTime orderdate, string ordernumber, int customerid, decimal totalamount)
        {
            this.Id = id;
            this.OrderDate = orderdate;
            this.OrderNumber = ordernumber;
            this.CustomerId = customerid;
            this.TotalAmount = totalamount;
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

        public void setOrderDate(DateTime orderDate)
        {
            OrderDate = _setOrderDate(orderDate);
        }

        private DateTime _setOrderDate(DateTime orderDate)
        {
            DateTime _orderDate = orderDate;

            return _orderDate;
        }

        public string setOrderNumber()
        {
            OrderNumber = _setOrderNumber();

            return OrderNumber;
        }

        private string _setOrderNumber()
        {
            string _orderNumber = "LS-"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-";


                char [] numbers = new System.Text.StringBuilder().Insert(0, "0123456789", 6).ToString().ToCharArray();
                _orderNumber +=  string .Join("",  numbers.OrderBy(o => Guid.NewGuid()).Take(6));

            return _orderNumber;
        }

        public void setCustomerId(int id)
        {
            Id = _setCustomerId(id);
        }
        private int _setCustomerId(int i)
        {
            int _id = i;
            return _id;
        }

        public void setTotalAmount(int id)
        {
            TotalAmount = _setTotalAmout(id);
        }
        private decimal _setTotalAmout(decimal i)
        {
            decimal _id = i;
            return _id;
        }
    }
}