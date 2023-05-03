using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]

    public class Meat : Product
    {
                private double weight;
                private Boolean kosher;
                private double fats;
                public Meat()
                {
                    this.setName(null);
                    this.setPrice(0);
                    Date d1 = new Date();
                    this.setExp(d1);
                    this.setCalories(0);
                    this.weight = 0;
                    this.kosher = true;
                    this.fats = 0;
                }

                public Meat(string name, double price, Date d1, int cal, double weight, Boolean kosher, double fats)
                {
                    
                    this.setName(name);
                    this.setPrice(price);
                    this.setExp(d1);
                    this.setCalories(cal);
                    this.weight = weight;
                    this.kosher = kosher;
                    this.fats = fats;
                }

                public void setWeight(double weight)
                {
                    this.weight = weight;
                }

                public double getWeight()
                {
                    return this.weight;
                }

                public void setKosher(Boolean kosher)
                {
                    this.kosher = kosher;
                }

                public Boolean getKosher()
                {
                    return this.kosher;
                }

                public void setFats(double fats)
                {
                    this.fats = fats;
                }

                public double getFats()
                {
                    return this.fats;
                }

        public override double Sales()//if you buy more then 3 get 80 shekels discount
        {
            if (this.getAmount() >= 3)
            {
                return (this.getPrice() * this.getAmount()) - 80;
            }

            return (this.getPrice() * this.getAmount());
        }

    }
}

