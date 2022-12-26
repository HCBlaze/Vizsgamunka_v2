using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazas.Classes
{
    internal class Product
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public int SupplierId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public string Package { get; private set; }
        public int Stock { get; private set; }
        public string ImageSrc { get; private set; }



        public Product()
        {

        }

        public Product(int id, string productname, int supplierid, decimal unitprice, string package, int stock, string imagesrc)
        {
            this.Id = id;
            this.ProductName = productname;
            this.SupplierId = supplierid;
            this.UnitPrice = unitprice;
            this.Package = package;
            this.Stock = stock;
            this.ImageSrc = imagesrc;
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

        public void setProductName(string productname)
        {
            ProductName = _setProductName(productname);
        }

        private string _setProductName(string productname)
        {
            return productname;
        }

        public void setSupplierId(int id)
        {
            SupplierId = _setSupplierId(id);
        }
        private int _setSupplierId(int i)
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

        public void setPackage(string a)
        {
            Package = _setPackage(a);
        }

        private string _setPackage(string a)
        {
            return a;
        }

        public void setStock(int stock)
        {
            Stock = _setStock(stock);
        }

        private int _setStock(int stock)
        {
            int _stock = stock;

            return _stock;
        }
        public void setImageSrc(string imagesrc)
        {
            ImageSrc = _setImageSrc(imagesrc);
        }

        private string _setImageSrc(string imagesrc)
        {
            string _imgsrc = imagesrc;

            return _imgsrc;
        }
    }
}
