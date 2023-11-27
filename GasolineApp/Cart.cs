using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task1_GasStation
{
    internal class Cart
    {
        List<Product> products;
        public Cart() { products = new List<Product>(); }
        private decimal _totalMiniCafe;
        private decimal _totalToPay;
        public decimal TotalGasStation { get; set; }
        public decimal TotalMiniCafe
        {
            get => products.Sum(e => e.Price * e.Count);
            set => _totalMiniCafe = value;
        }
        public decimal TotalToPay
        {
            get => TotalGasStation + TotalMiniCafe;
            set => _totalToPay = value;
        }
        public void AddProduct(Product product)
        {
            if (products.Any(e => e.Id.Equals(product.Id)))
            {
                products.FirstOrDefault(e => e.Id.Equals(product.Id)).Count += 1;
            }
            else
            {
                product.Count = 1;
                products.Add(product);
            }
        }
        public void RemoveProduct(Product product)
        {
            //products.Remove(products.Where(e => e.ID.Equals(product.ID)) as Product);
            products = products.Where(e => e.Id != product.Id).ToList();
        }

        public void ChangeAmount(string id, int count)
        {
            if (products.Any(e => e.Id.Equals(id)))
            {
                products.FirstOrDefault(e => e.Id.Equals(id)).Count = count;
            }
        }
    }
}