using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]
    public class Alcohol : Drinks
    {
        private double alcohol;
        public Alcohol()
        {
            this.setName(null);
            this.setPrice(0);
            Date d1 = new Date();
            this.setExp(d1);
            this.setCalories(0);
            this.setSugar(0);
            this.setCaffeine(false);
            this.alcohol = 0;
        }

        public Alcohol(string name, double price, Date d1, int cal, double sugar, Boolean caffeine, double alcohol)
        {
            this.setName(name);
            this.setPrice(price);
            this.setExp(d1);
            this.setCalories(cal);
            this.setSugar(sugar);
            this.setCaffeine(caffeine);
            this.alcohol = alcohol;
        }

        public void setAlcohol(double alcohol)
        {
            this.alcohol = alcohol;
        }

        public double getAlcohol()
        {
            return this.alcohol;
        }

        public override double Sales()//if you buy more then 2 get 30 shekels discount
        {
            if (this.getAmount() >= 2)
            {
                return (this.getPrice() * this.getAmount()) - 30;
            }

            return (this.getPrice() * this.getAmount());
        }
    }
}
