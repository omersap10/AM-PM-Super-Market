using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]
        public abstract class Product  
        {
            private string name;
            private double price;
            private Date exp=new Date();
            private int calories;
            private int amount = 0;


            public Product()
            {
                this.name = " ";
                this.price = 0;
                this.exp.setDay(1);
                this.exp.setMonth(1);
                this.exp.setYear(2000);
                this.calories = 0;
            }
            public Product(Date exp, double price, int calories, string name, int amount)
            {
                this.exp = exp;
                this.price = price;
                this.calories = calories;
                this.name = name;
                this.amount = amount;
            }

            public void setPrice(double price)
            {
                this.price = price;
            }

            public double getPrice()
            {
                return this.price;
            }

        public void setAmount(int amount) //if we want to choose the amount
        {
            this.amount = amount;
        }

        


            public int getAmount()
            {
                return this.amount;
            }
            public void setExp(Date date)
            {
                this.exp = date;
            }

            public Date getExp()
            {
                return this.exp;
            }

            public void setCalories(int calories)
            {
                this.calories = calories;
            }

            public int getCalories()
            {
                return this.calories;
            }

            public void setName(string name)
            {
                this.name = name; ;
            }

            public string getName()
            {
                return this.name;
            }

        public abstract double Sales();

        }
}

