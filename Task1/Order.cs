using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    internal class Order
    {
        private string _productName;
        public string ProductName 
        { 
            get
            {
                return _productName;
            }
            set 
            {
                _productName = value;
            }
        }

        private float _productPrice;
        public float ProductPrice 
        { 
            get
            {
                return _productPrice;
            }
            set
            {
                if (value > 0 && value < 1000) _productPrice = value;
            }
        }
        private long _buyerPhoneNumber;
        public long BuyerPhoneNumber 
        {
            get 
            {
                return _buyerPhoneNumber;
            }
            set 
            {
                if(value.ToString().Length == 13) _buyerPhoneNumber = value;
            }
        }
        
        private string _buyerAddress;
        public string BuyerAddress
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }

        public Order(string productName, float productPrice, long buyerPhoneNumber, string buyerAddress)
        {
            _productName = productName;
            _productPrice = productPrice;
            _buyerPhoneNumber = buyerPhoneNumber;
            _buyerAddress = buyerAddress;
        }

        public string GetFullOrderInfo()
        {
            return String.Format("Product Name-{0}, Product Price-{1}, Buyer Phone Number-{2}, buyer Address-{3}", _productName, ProductPrice,
                                                                                                                   _buyerPhoneNumber, _buyerAddress);
        }

    }
}
