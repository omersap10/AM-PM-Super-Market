using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    [Serializable]

    public class Non_Alcohol :Drinks
    {
        private Boolean carbonated;

        public Non_Alcohol()
        {
            this.setName(null);
            this.setPrice(0);
            Date d1 = new Date();
            this.setExp(d1);
            this.setCalories(0);
            this.setSugar(0);
            this.setCaffeine(false);
            this.carbonated = false;
        }

       public Non_Alcohol(string name, double price, Date d1, int cal, double sugar, Boolean caffeine,Boolean carbonated)
        {
            this.setName(name);
            this.setPrice(price);
            this.setExp(d1);
            this.setCalories(cal);
            this.setSugar(sugar);
            this.setCaffeine(caffeine);
            this.carbonated = carbonated;
        }

        public void setCarbonated(Boolean carbonated)
        {
            this.carbonated = carbonated;
        }

        public Boolean getCarbonated()
        {
            return this.carbonated;
        }
        public override double Sales()//if you buy more then 3 get 10 shekels discount
        {
            if (this.getAmount() >= 3)
            {
                return (this.getPrice() * this.getAmount()) - 10;
            }

            return (this.getPrice() * this.getAmount());
        }
    }
}
