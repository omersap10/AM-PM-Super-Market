using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]
    public class Snacks : Product
    {
            private double sugar;
            private double sodium;
            private double carbohydrate;

            public Snacks()
            {
                this.setName(null);
                this.setPrice(0);
                Date d1 = new Date();
                this.setExp(d1);
                this.setCalories(0);
                this.sugar = 0;
                this.sodium = 0;
                this.carbohydrate = 0;
            }

            public Snacks(string name, double price, Date d1, int cal, double sugar, double sodium, double carbohydrate)
            {
                this.setName(name);
                this.setPrice(price);
                this.setExp(d1);
                this.setCalories(cal);
                this.sugar = sugar;
                this.sodium = sodium;
                this.carbohydrate = carbohydrate;
            }

            public void setSugar(double sugar)
            {
                this.sugar = sugar;
            }

            public double getSugar()
            {
                return this.sugar;
            }

            public void setSodium(double sodium)
            {
                this.sodium = sodium;
            }

            public double getSodium()
            {
                return this.sodium;
            }

            public void setCarbohydrate(double carbohydrate)
            {
                this.carbohydrate = carbohydrate;
            }

            public double getCarbohydrate()
            {
                return this.carbohydrate;
            }
        public override double Sales()//if you buy more then 4 get 40 shekels discount
        {
            if (this.getAmount() >= 4)
            {
                return (this.getPrice()*this.getAmount())-40;
            }

            return (this.getPrice() * this.getAmount());
        }

    }
}
