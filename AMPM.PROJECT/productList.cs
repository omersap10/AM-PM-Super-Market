using System;
using System.Collections;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]
    public class productList
    {
        protected double totalPrice = 0;
        public double TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                this.totalPrice = value;
            }
        }
        protected SortedList products;

        public productList()
        {
            products = new SortedList();
        }

        public int nextIndex
        {
            get
            {
                return products.Count;
            }
        }

        public Product this[int index]
        {
            get
            {
                if (index >= products.Count)
                    return (Product)null;
                return (Product)products.GetByIndex(index);
            }
            set
            {
                if (index <= products.Count)
                    products[index] = value;
            }
        }

        public void Remove(int element)
        {
            if(element >= 0 && element < products.Count)
            {
                Product p = (Product)this.products.GetByIndex(element);
                if(p.getAmount() == 0)
                {
                  for (int i = element; i < products.Count - 1; i++)
                                products[i] = products[i + 1];
                  products.RemoveAt(products.Count - 1);
                }
                else
                {
                    p.setAmount(p.getAmount() - 1);
                }
          
                this.totalPrice -= p.Sales();
            }
        }

        public void calcSales()
        {
            for(int i = 0; i < products.Count; i++)
            {
                Product p = (Product)this.products.GetByIndex(i);
                this.totalPrice += p.Sales();
            }
        }


    }
}
