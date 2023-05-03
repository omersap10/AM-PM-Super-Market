using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]

    public class Dairy : Product
    {
            private double protein;
            private double fats;
            private double calcium;
            public Dairy()
            {
                this.setName(null);
                this.setPrice(0);
                Date d1 = new Date();
                this.setExp(d1);
                this.setCalories(0);
                this.protein = 0;
                this.fats = 0;
                this.calcium = 0;
            }
            public Dairy(string name, double price, Date d1, int cal, double protein, double fats, double calcium)
            {
                this.setName(name);
                this.setPrice(price);
                this.setExp(d1);
                this.setCalories(cal);
                this.protein = protein;
                this.fats = fats;
                this.calcium = calcium;
            }
            public void setProtein(double protein)
            {
                this.protein = protein;
            }
            public double getProtein()
            {
                return this.protein;
            }
            public void setCalcium(double calcium)
            {
                this.calcium = calcium;
            }
            public double getCalcium()
            {
                return this.calcium;
            }
            public void setFats(double fats)
            {
                this.fats = fats;
            }
            public double getFats()
            {
                return this.fats;
            }

        public override double Sales() //if you buy more then 5 get 20 shekels discount
        {
            if (this.getAmount() >= 5)
            {
                return (this.getPrice() * this.getAmount()) - 20;
            }

            return (this.getPrice() * this.getAmount());
        }

    }

    }

