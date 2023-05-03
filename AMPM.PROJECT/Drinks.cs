using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]
    public class Drinks : Product
    {
        private double sugar;
        private Boolean caffeine;


        public Drinks()
        {
            this.setName(null);
            this.setPrice(0);
            Date d1 = new Date();
            this.setExp(d1);
            this.setCalories(0);
            this.sugar = 0;
            this.caffeine = false;
        }

        public Drinks(string name, double price, Date d1, int cal, double sugar, Boolean caffeine)
        {
            this.setName(name);
            this.setPrice(price);
            this.setExp(d1);
            this.setCalories(cal);
            this.sugar = sugar;
            this.caffeine = caffeine;

        }

        public void setSugar(double sugar)
        {
            this.sugar = sugar;
        }

        public double getSugar()
        {
            return this.sugar;
        }

        public void setCaffeine(Boolean caffeine)
        {
            this.caffeine = caffeine;
        }

        public Boolean getCaffeine()
        {
            return this.caffeine;
        }

        public override double Sales()
        {
            return 0;
        }

    }
}